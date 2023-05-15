using MinerTech.Domain.Entities;
using MinerTech.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class Classe : BaseEntity
    {
        public decimal Capacidade { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public IList<Cargueiro> Cargueiros { get; set; }
        public List<ClasseMinerioCompativel> ClasseMineriosCompativeis { get; set; }

        public Classe(string descricao, decimal capacidade)
        {
            Descricao = descricao;
            Capacidade = capacidade;
            DataCadastro = DateTime.Now;
            Ativo = true;

            Validate(this, new ClasseValidator());
        }

        public void AlterarDescricao(string nome)
        {
            Descricao = nome;
        }

        public void Inativar()
        {
            Ativo = false;
        }

        public void AssociarMineriosCompativeis(List<Minerio> minerios)
        {
            ClasseMineriosCompativeis.AddRange(minerios.Select(x => new ClasseMinerioCompativel(x, this)));
        }
    }
}
