using MinerTech.Domain.Entities.Cargueiros;
using MinerTech.Domain.Validators;
using System.Reflection.PortableExecutable;

namespace MinerTech.Domain.Entities.Minerios
{
    public class Minerio : BaseEntity
    {
        public Minerio(string codigo, string caracteristica)
        {
            Codigo = codigo;
            Caracteristica = caracteristica;
            Ativo = true;

            Validate(this, new MinerioValidator());
        }

        public string Codigo { get; private set; }
        public decimal Preco { get; private set; }
        public string Caracteristica { get; private set; }
        public bool Ativo { get; private set; }
        public IList<RetornoCargueiro> RetornosCargueiro { get; private set; } 
        public IList<Cargueiro> Cargueiros { get; private set; }
        public IList<RetornoHistorico> RetornosHistorico { get; private set; }

        public virtual void CalcularPreco(decimal peso)
        {
            throw new NotImplementedException();
        }

        public void AlterarPreco(decimal peso) 
        {
            Preco = peso;
        }
        
        public void AlterarCaracteristica(string caracteristica)
        {
            Caracteristica = caracteristica;
        }

        public void Inativar()
        {
            Ativo = false;
        }
    }
}
