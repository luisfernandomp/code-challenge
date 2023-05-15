using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class MinerioA : Minerio
    {
        private const decimal _preco = 5000;
        private const int _prefix = 1000;

        public MinerioA(string codigo, string caracteristica) : base(codigo, caracteristica)
        {
        }

        public override void CalcularPreco(decimal peso)
        {
            Preco = (_preco * peso) / _prefix;
        }
    }
}
