using AutoMapper;
using Pomoday.Domain.Contracts.Requests;
using Pomoday.Domain.Contracts.Responses;
using Pomoday.Domain.Entities;
using Pomoday.Domain.Interfaces.Repository;
using Pomoday.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Service.Services
{
    public class UsuarioService : BaseService, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        public async Task<UsuarioResponse> CriarAsync(UsuarioRequest request)
        {
            var requestUsuarioEntity = _mapper.Map<Usuario>(request);
            //requestUsuarioEntity.Senha = Criptografia.Encrypt(request.Senha);
            await _usuarioRepository.AddAsync(requestUsuarioEntity);
            return _mapper.Map<UsuarioResponse>(requestUsuarioEntity);
        }

        public async Task<UsuarioResponse> AtualizarAsync(Guid? id, UsuarioRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task DeletarAsync(Guid id)
        {
            var usuarioBanco = await _usuarioRepository.FindAsync(id);
            if (usuarioBanco == null)
            {
                throw new ArgumentException("Usuário não encontrado");
            }
            if (usuarioBanco.Ativo == false)
            {
                throw new ArgumentException("Usuário já foi deletado");
            }
            usuarioBanco.Ativo = true;
            usuarioBanco.AlteradoEm = DateTime.Now;
            await _usuarioRepository.EditAsync(usuarioBanco);
        }

        public async Task<UsuarioResponse> ObterPorIdAsync(Guid id)
        {
            var usuarioBanco = await _usuarioRepository.FindAsync(x => x.Ativo && x.Id == id);
            if (usuarioBanco == null)
            {
                throw new ArgumentException("Usuário não encontrado");
            }
            return _mapper.Map<UsuarioResponse>(usuarioBanco);
        }

        public async Task<IEnumerable<UsuarioResponse>> ObterTodosAsync()
        {
            var listaUsuarios = await _usuarioRepository.ListAsync(x => x.Ativo);
            return _mapper.Map<IEnumerable<UsuarioResponse>>(listaUsuarios);
        }

        public async Task<UsuarioResponse> PutUsuario(UsuarioAlteracaoRequest request, Guid? id)
        {
            var usuarioBanco = await _usuarioRepository.FindAsync(x => x.Ativo);
            if (usuarioBanco == null)
            {
                throw new ArgumentException("Usuário não encontrado ou inativo");
            }
            usuarioBanco.Ativo = true;
            usuarioBanco.Nome = request.Nome;
            usuarioBanco.Email = request.Email;
            usuarioBanco.AlteradoEm = DateTime.Now;
            await _usuarioRepository.EditAsync(usuarioBanco);
            return _mapper.Map<UsuarioResponse>(usuarioBanco);
        }
    }
}
