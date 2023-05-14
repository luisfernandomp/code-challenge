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
        public IList<Cargueiro> Cargueiros { get; set; }
        public bool CadastrarClasse(string descricao)
        {
            Descricao = descricao;
            DataCadastro = DateTime.Now;
            Ativo = true;

            return true;
        }
    }
}
