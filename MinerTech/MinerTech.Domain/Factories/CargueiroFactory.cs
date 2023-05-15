using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Factories
{
    public class CargueiroFactory : AbstractFactoryMethod<Cargueiro>
    {
        public override Cargueiro Constroi(Cargueiro cargueiro)
        {
            switch (cargueiro.Classe.Descricao)
            {
                case "I": return new CargueiroI();
                case "II": return new CargueiroII();
                case "III": return new CargueiroIII();
                case "IV": return new CargueiroIV();
                default:
                    throw new Exception("Não foi possível concluir a operação!");
            }
        }
    }
}
