using MinerTech.Domain.Entities.Classes;
using MinerTech.Domain.Entities.Classes.Tipo;
using MinerTech.Domain.Entities.Minerios;

namespace MinerTech.Domain.Factories
{
    public class ClasseFactory : AbstractFactoryMethod<Classe>
    {
        public override Classe Constroi(Classe classe)
        {
            switch (classe.Minerio)
            {
                case MinerioD: return new ClasseI(classe.Descricao);
                case MinerioA: return new ClasseII(classe.Descricao); ;
                case MinerioC: return new ClasseIII(classe.Descricao); ;
                case MinerioB or MinerioC: return new ClasseIV(classe.Descricao);
                default:
                    throw new Exception("Não foi possível concluir a operação!");
            }
        }
    }
}
