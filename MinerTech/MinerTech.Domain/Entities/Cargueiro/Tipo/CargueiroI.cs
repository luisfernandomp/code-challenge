using MinerTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class CargueiroI : Cargueiro
    {
        public override void AlocarMinerio(Minerio minerio)
        {
            if (minerio is not MinerioD)
                return;

            if(PesoMinerio < Classe.Capacidade)
                CapacidadeOcupada += PesoMinerio - Classe.Capacidade;
            
            CapacidadeOcupada += PesoMinerio;
        } 
    }
}
