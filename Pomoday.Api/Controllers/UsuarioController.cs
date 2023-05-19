using Microsoft.AspNetCore.Mvc;
using Pomoday.Domain.Contracts.Requests;
using Pomoday.Domain.Contracts.Responses;
using Pomoday.Domain.Interfaces.Service;
using Swashbuckle.AspNetCore.Annotations;

namespace Pomoday.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
 
        [HttpPost]
        [SwaggerOperation(Summary = "Cadastra um novo usuário no banco.", Description = "Retorna dados do usuario.")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<UsuarioResponse>> Post([FromBody] UsuarioRequest usuario)
        {
            try
            {
                var result = await _usuarioService.CriarAsync(usuario);
                return Created(nameof(Post), result);
            }
            catch (ArgumentException exception)
            {
                return BadRequest(exception.Message);
            }
            catch (Exception ex) { return StatusCode(StatusCodes.Status500InternalServerError, ex.Message); }
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Busca um usuário por Id", Description = "Retorna o usuário se ele for encontrado. Caso contrário, retorna exception.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<UsuarioResponse>> GetById(Guid id)
        {
            try
            {
                var result = await _usuarioService.ObterPorIdAsync(id);
                return Ok(result);
            }
            catch(ArgumentException exception)
            {
                return NotFound(exception.Message);
            }
            catch (Exception ex) 
            { 
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message); 
            }
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Busca todos os usuários ativos.", Description = "Retorna todos os usuários ativos.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<UsuarioResponse>>> Get()
        {
            try
            {
                var result = await _usuarioService.ObterTodosAsync();
                return Ok(result);
            }
            catch(ArgumentException exception)
            {
                return NotFound(exception.Message);
            }
            catch (Exception ex) 
            { 
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message); 
            }
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Busca usuário para mudança de dados.", Description = "Retorna o usuário modificado.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<UsuarioResponse>> Put([FromBody] UsuarioAlteracaoRequest request, [FromRoute] Guid id)
        {
            try
            {
                var result = await _usuarioService.PutUsuario(request, id);
                return Ok(result);
            }
            catch(ArgumentException exception)
            {
                return NotFound(exception.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Delete([FromRoute] Guid id)
        {
            try
            {
                await _usuarioService.DeletarAsync(id);
                return NoContent();
            }
            catch(ArgumentException exception)
            {
                return NotFound(exception.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}