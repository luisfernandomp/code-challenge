using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class MineiroDto
    {
        public MineiroDto(string codigo, string caracteristica, decimal preco)
        {
            Codigo = codigo;
            Caracteristica = caracteristica;
            Preco = preco;
        }

        public string Codigo { get; set; }
        public string Caracteristica { get; set; }
        public decimal Preco { get; set; }
    }
}
