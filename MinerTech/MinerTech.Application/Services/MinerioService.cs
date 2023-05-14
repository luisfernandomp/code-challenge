using MinerTech.Domain;
using MinerTech.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Application.Services
{
    public class MinerioService : BaseService<Minerio>, IMinerioService
    {
        public MinerioService(IBaseRepository<Minerio> baseRepository) : base(baseRepository)
        {
        }
    }
}
