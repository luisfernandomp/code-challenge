using AutoMapper;
using MinerTech.Domain;
using MinerTech.Domain.Entities.Minerio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
