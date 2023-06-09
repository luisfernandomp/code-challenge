using MinerTech.Domain.Entities.Cargueiros;
using MinerTech.Domain.Entities.Minerios;
using MinerTech.Domain.Validators;

namespace MinerTech.Domain.Entities.Classes
{
    public class Classe : BaseEntity
    {
        public decimal Capacidade { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; set; }
        public int MinerioId { get; set; }
        public Minerio Minerio { get; private set; }
        public IList<Cargueiro> Cargueiros { get; private set; }

        public Classe(string descricao)
        {
            Descricao = descricao;
            DataCadastro = DateTime.Now;
            Ativo = true;

            Validate(this, new ClasseValidator());
        }

        public void AlterarCapacidade(decimal capacidade)
        {
            Capacidade = capacidade;
        }

        public void AlterarDescricao(string nome)
        {
            Descricao = nome;
        }

        public void Inativar()
        {
            Ativo = false;
        }

        public void AssociarMinerio(Minerio minerio)
        {
            Minerio = minerio;
        }
    }
}
