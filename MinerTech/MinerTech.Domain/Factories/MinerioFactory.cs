using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Factories
{
    public class MinerioFactory : AbstractFactoryMethod<Minerio>
    {
        public override Minerio Constroi(string name)
        {
            switch (name)
            {
                case "A": return new MinerioA();
                case "B": return new MinerioB();
                case "C": return new MinerioC();
                default: throw new Exception("Não foi possível completar a operação!");
            }
        }
    }
}
