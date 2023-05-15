using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class CargueiroIII : Cargueiro
    {
        public override void AlocarMinerio(Minerio minerio)
        {
            if (minerio is not MinerioC)
                return;

            if (PesoMinerio < Classe.Capacidade)
                CapacidadeOcupada += PesoMinerio - Classe.Capacidade;

            CapacidadeOcupada += PesoMinerio;
        }
    }
}
