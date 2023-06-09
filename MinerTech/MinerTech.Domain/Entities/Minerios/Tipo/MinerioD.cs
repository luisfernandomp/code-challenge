namespace MinerTech.Domain.Entities.Minerios
{
    public class MinerioD : Minerio
    {
        private const decimal _preco = 100;
        private const decimal _prefix = 0.01M;

        public MinerioD(string codigo, string caracteristica) : base(codigo, caracteristica)
        {
        }

        public override void CalcularPreco(decimal peso)
        {
            AlterarPreco((_preco * peso) / _prefix);
        }
    }
}
