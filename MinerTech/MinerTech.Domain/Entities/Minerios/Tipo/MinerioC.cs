using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Entities.Minerios
{
    public class MinerioC : Minerio
    {
        private const decimal _preco = 3000;
        private const decimal _prefix = 0.1M;

        public MinerioC(string codigo, string caracteristica) : base(codigo, caracteristica)
        {
        }

        public override void CalcularPreco(decimal peso)
        {
            AlterarPreco((_preco * peso) / _prefix);
        }
    }
}
