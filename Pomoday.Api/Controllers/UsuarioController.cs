﻿using Microsoft.AspNetCore.Mvc;
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

        /// <summary>
        /// Realiza cadastro de novo usuário.
        /// </summary>
        /// <returns>Usuário cadastrado</returns>
        /// <response code="201">Retorna usuário cadastrado</response>
        /// <response code="400">Se o item não for criado</response> 
        [HttpPost]
        [SwaggerOperation(Summary = "Cadastra um novo usuario no banco.", Description = "Retorna dados do usuario.")]
        [ProducesResponseType(201)]
        public async Task<ActionResult<UsuarioResponse>> Post([FromBody] UsuarioRequest usuario)
        {
            var result = await _usuarioService.CriarAsync(usuario);
            return Ok(result);
        }
        /// <summary>
        /// Realiza uma busca de usuário por Id.
        /// </summary>
        /// <returns>Usuário</returns>
        /// <response code="200">Retorna usuário</response>
        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Busca um usuário por Id", Description = "Retorna o usuário se ele for encontrado. Caso contrário, retorna exception.")]
        [ProducesResponseType(200)]
        public async Task<ActionResult<UsuarioResponse>> GetById(Guid id)
        {
            var result = await _usuarioService.ObterPorIdAsync(id);
            return Ok(result);
        }
        /// <summary>
        /// Realiza busca de todos os usuários.
        /// </summary>
        /// <returns>Usuário</returns>
        /// <response code="200">Retorna usuários</response>
        [HttpGet]
        [SwaggerOperation(Summary = "Busca todos os usuários ativos.", Description = "Retorna todos os usuários Ativos.")]
        [ProducesResponseType(200)]
        public async Task<ActionResult<IEnumerable<UsuarioResponse>>> Get()
        {
            var result = await _usuarioService.ObterTodosAsync();
            return Ok(result);
        }

        /// <summary>
        /// Busca um usuário e realiza mudança de dados.
        /// </summary>   
        ///<returns>Usuário modificado</returns>
        /// <response code="200">Se o objeto existe e foi alterado</response>
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [SwaggerOperation(Summary = "Busca usuário para mudança de dados.", Description = "Retorna o usuário modificado.")]
        public async Task<ActionResult<UsuarioResponse>> Put([FromBody] UsuarioAlteracaoRequest request, [FromRoute] Guid id)
        {
            var result = await _usuarioService.PutUsuario(request, id);
            return Ok(result);
        }

        /// <summary>
        /// Deleta usuário.
        /// </summary>            
        /// <response code="200">Se o objeto existe</response>
        /// <response code="404">Se o objeto não existe</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        public async Task<ActionResult> Delete([FromRoute] Guid id)
        {
            await _usuarioService.DeletarAsync(id);
            return NoContent();
        }
    }
}