using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Factories
{
    public abstract class AbstractFactoryMethod<T> where T : class
    {
        public abstract T Constroi(T obj);
    }
}
