
using MinerTech.Domain.Entities.Minerios;

namespace MinerTech.Domain.Entities.Classes.Tipo
{
    public class ClasseIV : Classe
    {
        public ClasseIV(string descricao) : base(descricao)
        {
        }

        public void DefinirCapacidade()
        {
            AlterarCapacidade(5000);
        }

        public void DefinirMinerio(MinerioB minerio)
        {
            AssociarMinerio(minerio);
        }

        public void DefinirMinerio(MinerioC minerio)
        {
            AssociarMinerio(minerio);
        }

    }
}
