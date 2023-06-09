
using MinerTech.Domain.Entities.Minerios;

namespace MinerTech.Domain.Entities.Classes.Tipo
{
    public class ClasseII : Classe
    {
        public ClasseII(string descricao) : base(descricao)
        {
        }

        public void DefinirCapacidade()
        {
            AlterarCapacidade(5000);
        }

        public void DefinirMinerio(MinerioA minerio)
        {
            AssociarMinerio(minerio);
        }

    }
}
