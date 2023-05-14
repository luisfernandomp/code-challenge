using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class CargueiroDto
    {
        public int ClasseId { get; set; }
        public int MinerioId { get; set; }
        public decimal Capacidade { get; set; }
        public decimal CapacidadeOcupada { get; set; }
        public decimal PesoMinerio { get; set; }
    }
}
