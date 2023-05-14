using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class CargueiroII : Cargueiro
    { 
        public override void AlocarMinerio(Minerio minerio)
        {
            if (minerio is not MinerioA)
                return;

            if (PesoMinerio < Capacidade)
                CapacidadeOcupada += PesoMinerio - Capacidade;

            CapacidadeOcupada += PesoMinerio;
        }
    }
}
