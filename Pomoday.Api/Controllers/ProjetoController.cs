using Microsoft.AspNetCore.Mvc;
using Pomoday.Domain.Contracts.Requests;
using Pomoday.Domain.Contracts.Responses;
using Pomoday.Domain.Interfaces.Service;
using Pomoday.Service.Services;
using Swashbuckle.AspNetCore.Annotations;

namespace Pomoday.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjetoController :ControllerBase
    {
        private readonly IProjetoService _projetoService;

        public ProjetoController(IProjetoService projetoService)
        {
            _projetoService = projetoService;
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Cadastra um novo projeto no banco.", Description = "Retorna dados do projeto.")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ProjetoResponse>> Post([FromBody] ProjetoRequest projeto)
        {
            try
            {
                var result = await _projetoService.CriarAsync(projeto);
                return Created(nameof(Post), result);
            }
            catch (ArgumentException exception)
            {
                return BadRequest(exception.Message);
            }
            catch (Exception ex) { return StatusCode(StatusCodes.Status500InternalServerError, ex.Message); }
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Busca um projeto por Id", Description = "Retorna um projeto se ele for encontrado. Caso contrário, retorna exception.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ProjetoResponse>> GetById(Guid id)
        {
            try
            {
                var result = await _projetoService.ObterPorIdAsync(id);
                return Ok(result);
            }
            catch (ArgumentException exception)
            {
                return NotFound(exception.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Busca todos os projetos ativos.", Description = "Retorna todos os projetos ativos.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ProjetoResponse>>> Get()
        {
            try
            {
                var result = await _projetoService.ObterTodosAsync();
                return Ok(result);
            }
            catch (ArgumentException exception)
            {
                return NotFound(exception.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Busca projeto para mudança de dados.", Description = "Retorna o projeto modificado.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<TarefaResponse>> Put([FromBody] ProjetoRequest request, [FromRoute] Guid id)
        {
            try
            {
                var result = await _projetoService.AtualizarAsync(id, request);
                return Ok(result);
            }
            catch (ArgumentException exception)
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
                await _projetoService.DeletarAsync(id);
                return NoContent();
            }
            catch (ArgumentException exception)
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
