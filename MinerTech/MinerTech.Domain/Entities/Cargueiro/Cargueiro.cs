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
        public decimal Capacidade { get; protected set; }
        public decimal CapacidadeOcupada { get; protected set; }
        public decimal PesoMinerio { get; set; }
        public int ClasseId { get; set; }
        public Classe Classe { get; set; }
        public int MinerioId { get; set; }
        public Minerio Minerio { get; set; }
        public CargueiroQuantidade CargueiroQuantidade { get; set; }
        public IList<RetornoHistorico> RetornosHistorico { get; set; }
        public IList<RetornoCargueiro> RetornosCargueiro { get; set; }
        public Cargueiro() { }

        public bool CapacidadeDisponivel(decimal valor) 
        {
            if (valor > Capacidade) return false;

            return true;
        }

        public virtual void AlocarMinerio(Minerio minerio)
        {

        }
    }
}
