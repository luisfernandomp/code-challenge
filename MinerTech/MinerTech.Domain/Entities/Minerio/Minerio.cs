using MinerTech.Domain.Entities;
using MinerTech.Domain.Validators;

namespace MinerTech.Domain
{
    public class Minerio : BaseEntity
    {
        public Minerio(string codigo, string caracteristica)
        {
            Codigo = codigo;
            Caracteristica = caracteristica;

            Validate(this, new MinerioValidator());
        }

        public string Codigo { get; set; }
        public decimal Preco { get; set; }
        public string Caracteristica { get; set; }
        public bool Ativo { get; set; }
        public IList<RetornoCargueiro> RetornosCargueiro { get; set; } 
        public IList<Cargueiro> Cargueiros { get; set; }
        public IList<RetornoHistorico> RetornosHistorico { get; set; }
        public IList<ClasseMinerioCompativel> ClasseMineriosCompativeis { get; set; }

        public virtual void CalcularPreco(decimal peso)
        { }
        
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
