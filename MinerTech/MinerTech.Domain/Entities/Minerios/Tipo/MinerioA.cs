namespace MinerTech.Domain.Entities.Minerios
{
    public class MinerioA : Minerio
    {
        private const decimal _preco = 5000;
        private const int _prefix = 1000;

        public MinerioA(string codigo, string caracteristica) : base(codigo, caracteristica)
        {
        }

        public override void CalcularPreco(decimal peso)
        {
            AlterarPreco((_preco * peso) / _prefix);
        }
    }
}
