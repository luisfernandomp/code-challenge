using MinerTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class CargueiroMinerio : BaseEntity
    {
        public int MinerioId { get; set; }
        public Minerio Minerio { get; set; }
        public int CargueiroId { get; set; }
        public Cargueiro Cargueiro { get; set; } 

        public decimal CalcularCapacidadeDisponivel()
        {
            return 0.0M;
        }
    }
}
