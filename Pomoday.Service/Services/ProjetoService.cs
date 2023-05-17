using AutoMapper;
using Pomoday.Domain.Contracts.Requests;
using Pomoday.Domain.Contracts.Responses;
using Pomoday.Domain.Entities;
using Pomoday.Domain.Interfaces.Repository;
using Pomoday.Domain.Interfaces.Service;

namespace Pomoday.Service.Services
{
    public class ProjetoService : BaseService, IProjetoService
    {
        private readonly IProjetoRepository _projetoRepository;
        private readonly IMapper _mapper;
        public async Task<ProjetoResponse> CriarAsync(ProjetoRequest request)
        {
            var requestProjetoEntity = _mapper.Map<Projeto>(request);
            await _projetoRepository.AddAsync(requestProjetoEntity);
            return _mapper.Map<ProjetoResponse>(requestProjetoEntity);
        }

        public async Task<ProjetoResponse> AtualizarAsync(Guid? id, ProjetoRequest request)
        {
            var projetoBanco = await _projetoRepository.FindAsync(x => x.Ativo);
            if (projetoBanco == null)
            {
                throw new ArgumentException("Projeto não encontrado ou inativo");
            }
            projetoBanco.Ativo = true;
            projetoBanco.Nome = request.Nome;
            projetoBanco.Prazo = request.Prazo;
            projetoBanco.AlteradoEm = DateTime.Now;
            await _projetoRepository.EditAsync(projetoBanco);
            return _mapper.Map<ProjetoResponse>(projetoBanco);
        }

        public async Task DeletarAsync(Guid id)
        {
            var projetoBanco = await _projetoRepository.FindAsync(id);
            if (projetoBanco == null)
            {
                throw new ArgumentException("Projeto não encontrado");
            }
            if (projetoBanco.Ativo == false)
            {
                throw new ArgumentException("Projeto já foi deletado");
            }
            projetoBanco.Ativo = true;
            projetoBanco.AlteradoEm = DateTime.Now;
            await _projetoRepository.EditAsync(projetoBanco);
        }

        public async Task<ProjetoResponse> ObterPorIdAsync(Guid id)
        {
            var projetoBanco = await _projetoRepository.FindAsync(x => x.Ativo && x.Id == id);
            if (projetoBanco == null)
            {
                throw new ArgumentException("Projeto não encontrado");
            }
            return _mapper.Map<ProjetoResponse>(projetoBanco);
        }

        public async Task<IEnumerable<ProjetoResponse>> ObterTodosAsync()
        {
            var listaProjetos = await _projetoRepository.ListAsync(x => x.Ativo);
            return _mapper.Map<IEnumerable<ProjetoResponse>>(listaProjetos);
        }
    }
}
