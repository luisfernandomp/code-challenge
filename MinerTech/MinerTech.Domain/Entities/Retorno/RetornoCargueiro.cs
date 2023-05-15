using MinerTech.Domain.Entities;
using MinerTech.Domain.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class RetornoCargueiro : BaseEntity
    {
        public int MineiroId { get; set; }
        public Minerio Minerio { get; set; }
        public int CargueiroId { get; set; }
        public Cargueiro Cargueiro { get; set; }

        public decimal CalcularPrecoTotal() 
        {
            var minerio = new MinerioFactory()
                .Constroi(Minerio);

            minerio.CalcularPreco(Cargueiro.PesoMinerio);

            return minerio.Preco;
        }

        public void AlocarMinerioCargueiro()
        {
            var cargueiro = new CargueiroFactory().Constroi(Cargueiro);
            cargueiro.AlocarMinerio(Minerio);
        }

    }
}
