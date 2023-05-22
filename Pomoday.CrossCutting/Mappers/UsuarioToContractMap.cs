using AutoMapper;
using Pomoday.Domain.Contracts.Requests;
using Pomoday.Domain.Contracts.Responses;
using Pomoday.Domain.Entities;

namespace Pomoday.CrossCutting.Mappers
{
    public class UsuarioToContractMap : Profile
    {
        public UsuarioToContractMap()
        {
            CreateMap<Usuario, UsuarioRequest>().ReverseMap();
            CreateMap<Usuario, UsuarioResponse>().ReverseMap();
            CreateMap<Usuario, UsuarioAlteracaoRequest>().ReverseMap();
        }
    }
}
