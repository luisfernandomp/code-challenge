using MinerTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public abstract class Cargueiro : BaseEntity
    {
        public decimal Capacidade { get; private set; }
        public int ClasseId { get; set; }
        public Classe Classe { get; set; }
        public CargueiroMinerio CargueiroMineiro { get; set; }
        public CargueiroQuantidade CargueiroQuantidade { get; set; }
        public ICollection<Retorno> Retornos { get; set; }
        public ICollection<CargueiroMinerio> CargueirosMinerios { get; set; }
        public Cargueiro() { }

        public bool VerificarCapacidade(decimal valor) 
        {
            return false;
        }

        public abstract decimal AlocarMinerio(Minerio minerio);
    }
}
