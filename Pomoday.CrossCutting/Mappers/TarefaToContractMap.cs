using AutoMapper;
using Pomoday.Domain.Contracts.Requests;
using Pomoday.Domain.Contracts.Responses;
using Pomoday.Domain.Entities;

namespace Pomoday.CrossCutting.Mappers
{
    public class TarefaToContractMap : Profile
    {
        public TarefaToContractMap()
        {
            CreateMap<Tarefa, TarefaRequest>().ReverseMap();
            CreateMap<Tarefa, TarefaResponse>().ReverseMap();
        }
    }
}
