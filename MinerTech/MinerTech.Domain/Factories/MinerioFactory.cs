using MinerTech.Domain.Entities.Minerios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Factories
{
    public class MinerioFactory : AbstractFactoryMethod<Minerio>
    {
        public override Minerio Constroi(Minerio minerio)
        {
            switch (minerio.Codigo)
            {
                case "A": return new MinerioA(minerio.Codigo, minerio.Caracteristica);
                case "B": return new MinerioB(minerio.Codigo, minerio.Caracteristica);
                case "C": return new MinerioC(minerio.Codigo, minerio.Caracteristica);
                default: throw new Exception("Não foi possível completar a operação!");
            }
        }
    }
}
