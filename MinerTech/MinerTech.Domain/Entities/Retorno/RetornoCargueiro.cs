using MinerTech.Domain.Entities;
using MinerTech.Domain.Entities.Cargueiros;
using MinerTech.Domain.Entities.Minerios;
using MinerTech.Domain.Factories;

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

            //nerio.CalcularPreco(Cargueiro.PesoMinerio);

            return minerio.Preco;
        }

        public void AlocarMinerioCargueiro()
        {
            //var cargueiro = new CargueiroFactory().Constroi(Cargueiro);
            //cargueiro.AlocarMinerio(Minerio);
        }

    }
}
