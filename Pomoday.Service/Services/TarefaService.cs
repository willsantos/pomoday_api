using AutoMapper;
using Pomoday.Domain.Contracts.Requests;
using Pomoday.Domain.Contracts.Responses;
using Pomoday.Domain.Interfaces.Repository;
using Pomoday.Domain.Interfaces.Service;

namespace Pomoday.Service.Services
{
    public class TarefaService : BaseService, ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IMapper _mapper;

        public Task<TarefaResponse> CriarAsync(TarefaRequest request)
        {
            throw new NotImplementedException();
        }
        public Task<TarefaResponse> AtualizarAsync(Guid? id, TarefaRequest request)
        {
            throw new NotImplementedException();
        }


        public Task DeletarAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TarefaResponse> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TarefaResponse>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
