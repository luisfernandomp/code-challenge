

namespace MinerTech.Domain.Entities.Cargueiros
{
    public class CargueiroQuantidade : BaseEntity
    {
        public int Quantidade { get; set; }
        public int CargueiroId { get; set; }
        public Cargueiro Cargueiro { get; set; }

        private CargueiroQuantidade() { }
        public CargueiroQuantidade(int quantidade, Cargueiro cargueiro)
        {
            Quantidade = quantidade;
            Cargueiro = cargueiro;
        }
        
        public static CargueiroQuantidade CadastrarCargueiroQuantidade(int quantidade, Cargueiro cargueiro)
        {
            return new CargueiroQuantidade(quantidade, cargueiro);
        }

    }
}
