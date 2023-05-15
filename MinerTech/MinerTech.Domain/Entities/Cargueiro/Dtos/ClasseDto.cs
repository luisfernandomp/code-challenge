using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Entities.Cargueiro.Dtos
{
    public class ClasseDto
    {
        public string Descricao { get; set; }
        public decimal Capacidade { get; set; }
        public int[] MineriosCompativeis { get; set; }
    }
}
