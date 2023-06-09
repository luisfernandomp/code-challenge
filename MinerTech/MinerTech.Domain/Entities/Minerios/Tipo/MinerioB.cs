namespace MinerTech.Domain.Entities.Minerios
{
    public class MinerioB : Minerio
    {
        private const decimal _preco = 10000;
        private const decimal _prefix = 000.1M;

        public MinerioB(string codigo, string caracteristica) : base(codigo, caracteristica)
        {
        }

        public override void CalcularPreco(decimal peso)
        {
            AlterarPreco((_preco * peso) / _prefix);
        }
    }
}
