using MinerTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class Usuario : BaseEntity
    {
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; set; }
        public ICollection<Retorno> Retornos { get; set;}
        public ICollection<RetornoHistorico> RetornosHistorico { get; set; }
    }
}
