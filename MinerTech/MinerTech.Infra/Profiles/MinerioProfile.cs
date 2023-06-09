using AutoMapper;
using MinerTech.Domain;
using MinerTech.Domain.Entities.Minerios;
using MinerTech.Domain.Entities.Minerios.Dtos;

namespace MinerTech.Infra.Profiles
{
    public class MinerioProfile : Profile
    {
        public MinerioProfile()
        {
            CreateMap<Minerio, MinerioDto>();
            CreateMap<Minerio, MinerioResponseDto>();
        }
    }
}
