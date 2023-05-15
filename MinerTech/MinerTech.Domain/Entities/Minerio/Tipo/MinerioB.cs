using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class MinerioB : Minerio
    {
        private const decimal _preco = 10000;
        private const decimal _prefix = 000.1M;

        public MinerioB(string codigo, string caracteristica) : base(codigo, caracteristica)
        {
        }

        public override void CalcularPreco(decimal peso)
        {
            Preco = (_preco * peso) / _prefix;
        }
    }
}
