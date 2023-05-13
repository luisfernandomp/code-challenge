using MinerTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class Classe : BaseEntity
    {
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Cargueiro> Cargueiros { get; set; }
        public void CadastrarClasse(string descricao)
        {
            Descricao = descricao;
            DataCadastro = DateTime.Now;
            Ativo = true;
        }
    }
}
