using MinerTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class Cargueiro : BaseEntity
    {
        public decimal CapacidadeOcupada { get; set; }
        public decimal PesoMinerio { get; set; }
        public int ClasseId { get; set; }
        public Classe Classe { get; set; }
        public int MinerioId { get; set; }
        public Minerio Minerio { get; set; }
        public CargueiroQuantidade CargueiroQuantidade { get; set; }
        public IList<RetornoHistorico> RetornosHistorico { get; set; }
        public IList<RetornoCargueiro> RetornosCargueiro { get; set; }
        public Cargueiro() { }

        public decimal CapacidadeDisponivel(decimal valor) 
        {
            return Classe.Capacidade - PesoMinerio;
        }

        public virtual void AlocarMinerio(Minerio minerio)
        {

        }
    }
}
