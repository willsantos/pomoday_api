using AutoMapper;
using Pomoday.Domain.Contracts.Requests;
using Pomoday.Domain.Contracts.Responses;
using Pomoday.Domain.Entities;

namespace Pomoday.CrossCutting.Mappers
{
    public class RegistroToContractMap : Profile
    {
        public RegistroToContractMap()
        {
            CreateMap<Registro, RegistroRequest>().ReverseMap();
            CreateMap<Registro, RegistroResponse>().ReverseMap();
        }
    }
}
