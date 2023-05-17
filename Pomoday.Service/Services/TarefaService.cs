using AutoMapper;
using Pomoday.Domain.Contracts.Requests;
using Pomoday.Domain.Contracts.Responses;
using Pomoday.Domain.Entities;
using Pomoday.Domain.Interfaces.Repository;
using Pomoday.Domain.Interfaces.Service;

namespace Pomoday.Service.Services
{
    public class TarefaService : BaseService, ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IMapper _mapper;

        public async Task<TarefaResponse> CriarAsync(TarefaRequest request)
        {
            var requestTarefaEntity = _mapper.Map<Tarefa>(request);
            await _tarefaRepository.AddAsync(requestTarefaEntity);
            return _mapper.Map<TarefaResponse>(requestTarefaEntity);
        }
        public async Task<TarefaResponse> AtualizarAsync(Guid? id, TarefaRequest request)
        {
            var tarefaBanco = await _tarefaRepository.FindAsync(x => x.Ativo);
            if (tarefaBanco == null)
            {
                throw new ArgumentException("Tarefa não encontrada ou inativa");
            }
            tarefaBanco.Ativo = true;
            tarefaBanco.Nome = request.Nome;
            tarefaBanco.Prazo = request.Prazo;
            tarefaBanco.Agendada = request.Agendada;
            tarefaBanco.TempoGasto = request.TempoGasto;
            tarefaBanco.AlteradoEm = DateTime.Now;
            await _tarefaRepository.EditAsync(tarefaBanco);
            return _mapper.Map<TarefaResponse>(tarefaBanco);
        }


        public async Task DeletarAsync(Guid id)
        {
            var tarefaBanco = await _tarefaRepository.FindAsync(id);
            if (tarefaBanco == null)
            {
                throw new ArgumentException("Tarefa não encontrada");
            }
            if (tarefaBanco.Ativo == false)
            {
                throw new ArgumentException("Tarefa já foi deletada");
            }
            tarefaBanco.Ativo = true;
            tarefaBanco.AlteradoEm = DateTime.Now;
            await _tarefaRepository.EditAsync(tarefaBanco);
        }

        public async Task<TarefaResponse> ObterPorIdAsync(Guid id)
        {
            var tarefaBanco = await _tarefaRepository.FindAsync(x => x.Ativo && x.Id == id);
            if (tarefaBanco == null)
            {
                throw new ArgumentException("Tarefa não encontrada");
            }
            return _mapper.Map<TarefaResponse>(tarefaBanco);
        }

        public async Task<IEnumerable<TarefaResponse>> ObterTodosAsync()
        {
            var listaTarefas = await _tarefaRepository.ListAsync(x => x.Ativo);
            return _mapper.Map<IEnumerable<TarefaResponse>>(listaTarefas);
        }
    }
}
