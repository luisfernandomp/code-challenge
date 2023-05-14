using AutoMapper;
using MinerTech.Domain;
using MinerTech.Domain.Entities;
using MinerTech.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Application.Services
{
    public class RetornoService : BaseService<Retorno>, IRetornoService
    {
        public RetornoService(IBaseRepository<Retorno> baseRepository,
            NotificationContext notificationContext,
            IMapper mapper) :
            base(baseRepository, notificationContext, mapper)
        { }
    }
}
