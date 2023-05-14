using MinerTech.Domain;
using MinerTech.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Application.Services
{
    public class ClasseService : BaseService<Classe>, IClasseService
    {
        public ClasseService(IBaseRepository<Classe> baseRepository) : base(baseRepository)
        {
        }
    }
}
