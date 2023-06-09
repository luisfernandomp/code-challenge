﻿
using MinerTech.Domain.Entities.Minerios;

namespace MinerTech.Domain.Entities.Classes.Tipo
{
    public class ClasseI : Classe
    {
        public ClasseI(string descricao) : base(descricao)
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
