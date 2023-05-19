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
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaService _tarefaService;

        public TarefaController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Cadastra uma nova tarefa no banco.", Description = "Retorna dados da tarefa.")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<TarefaResponse>> Post([FromBody] TarefaRequest tarefa)
        {
            try
            {
                var result = await _tarefaService.CriarAsync(tarefa);
                return Created(nameof(Post), result);
            }
            catch (ArgumentException exception)
            {
                return BadRequest(exception.Message);
            }
            catch (Exception ex) { return StatusCode(StatusCodes.Status500InternalServerError, ex.Message); }
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Busca uma tarefa por Id", Description = "Retorna uma tarefa se ela for encontrada. Caso contrário, retorna exception.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<TarefaResponse>> GetById(Guid id)
        {
            try
            {
                var result = await _tarefaService.ObterPorIdAsync(id);
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
        [SwaggerOperation(Summary = "Busca todas as tarefas ativas.", Description = "Retorna todas as tarefas ativas.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<TarefaResponse>>> Get()
        {
            try
            {
                var result = await _tarefaService.ObterTodosAsync();
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
        [SwaggerOperation(Summary = "Busca tarefa para mudança de dados.", Description = "Retorna o tarefa modificada.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<TarefaResponse>> Put([FromBody] TarefaRequest request, [FromRoute] Guid id)
        {
            try
            {
                var result = await _tarefaService.AtualizarAsync(id, request);
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
        public async Task<ActionResult> Delete([FromRoute] Guid id)
        {
            try
            {
                await _tarefaService.DeletarAsync(id);
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
