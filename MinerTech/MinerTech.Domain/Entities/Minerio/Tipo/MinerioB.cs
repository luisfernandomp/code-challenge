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

        public override decimal CalcularPreco(decimal peso)
        {
            return (_preco * peso) / _prefix;
        }
    }
}
