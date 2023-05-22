using AutoMapper;
using Pomoday.Domain.Contracts.Requests;
using Pomoday.Domain.Contracts.Responses;
using Pomoday.Domain.Entities;

namespace Pomoday.CrossCutting.Mappers
{
    public class ProjetoToContractMap : Profile
    {
        public ProjetoToContractMap()
        {
            CreateMap<Projeto, ProjetoRequest>().ReverseMap();
            CreateMap<Projeto, ProjetoResponse>().ReverseMap();
        }
    }
}
