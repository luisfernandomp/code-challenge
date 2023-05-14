using FluentValidation;
using MinerTech.Domain;
using MinerTech.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Application.Services
{
    public class CargueiroService : BaseService<Cargueiro>, ICargueiroService
    {
        public CargueiroService(IBaseRepository<Cargueiro> baseRepository) : base(baseRepository)
        {
        }
    }
}
