using MinerTech.Domain.Entities.Classes;
using MinerTech.Domain.Entities.Minerios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Entities.Cargueiros
{
    public class Cargueiro : BaseEntity
    {
        public decimal CapacidadeOcupada { get; private set; }
        public int ClasseId { get; private set; }
        public Classe Classe { get; private set; }
        public int MinerioId { get; private set; }
        public Minerio Minerio { get; private set; }
        public CargueiroQuantidade CargueiroQuantidade { get; private set; }
        public IList<RetornoHistorico> RetornosHistorico { get; private set; }
        public IList<RetornoCargueiro> RetornosCargueiro { get; private set; }
        public Cargueiro() { }

        public decimal CapacidadeDisponivel(decimal valor)
        {
            return 0;
        }

        public virtual void AlocarMinerio(Minerio minerio)
        {

        }
    }
}
