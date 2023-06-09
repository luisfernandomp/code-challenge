
using MinerTech.Domain.Entities.Minerios;

namespace MinerTech.Domain.Entities.Classes.Tipo
{
    public class ClasseIII : Classe
    {
        public ClasseIII(string descricao) : base(descricao)
        {
        }

        public void DefinirCapacidade()
        {
            AlterarCapacidade(5000);
        }

        public void DefinirMinerio(MinerioC minerio)
        {
            AssociarMinerio(minerio);
        }

    }
}
