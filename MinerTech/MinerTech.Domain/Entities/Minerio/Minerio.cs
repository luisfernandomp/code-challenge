using MinerTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public abstract class Minerio : BaseEntity
    {
        public string Codigo { get; set; }
        public string Caracteristica { get; set; }
        public decimal Preco { get; set; }
        public ICollection<CargueiroMinerio> CargueirosMinerios { get; set; } 
        public abstract decimal CalcularPreco(decimal peso);
    }
}
