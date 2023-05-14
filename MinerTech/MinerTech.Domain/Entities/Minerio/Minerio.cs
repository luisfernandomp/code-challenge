using MinerTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class Minerio : BaseEntity
    {
        public string Codigo { get; set; }
        public string Caracteristica { get; set; }
        public decimal Preco { get; set; }
        public IList<RetornoCargueiro> RetornosCargueiro { get; set; } 
        public IList<Cargueiro> Cargueiros { get; set; }
        public IList<RetornoHistorico> RetornosHistorico { get; set; }
        public virtual decimal CalcularPreco(decimal peso)
        {
            return 0M;
        }
    }
}
