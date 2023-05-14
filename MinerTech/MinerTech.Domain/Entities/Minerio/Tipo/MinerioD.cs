using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class MinerioD : Minerio
    {
        private const decimal _preco = 100;
        private const decimal _prefix = 0.01M;

        public override decimal CalcularPreco(decimal peso)
        {
            return (_preco * peso) / _prefix;
        }
    }
}
