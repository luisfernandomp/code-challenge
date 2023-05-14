using AutoMapper;
using MinerTech.Domain;
using MinerTech.Domain.Entities.Usuario.Dto;

namespace MinerTech.Infra.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UsuarioResponseDto>().ReverseMap();
        }
    }
}
