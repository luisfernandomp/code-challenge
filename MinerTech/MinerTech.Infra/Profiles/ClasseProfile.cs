using AutoMapper;
using MinerTech.Domain;
using MinerTech.Domain.Entities.Cargueiro.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Infra.Profiles
{
    public class ClasseProfile : Profile
    {
        public ClasseProfile()
        {
            CreateMap<Classe, ClasseDto>().ReverseMap();
            CreateMap<Classe, ClasseResponseDto>().ReverseMap();
        }
    }
}
