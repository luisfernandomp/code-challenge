using MinerTech.Domain.Entities;
using MinerTech.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class Usuario : BaseEntity
    {
        public Usuario(string email, string senha, string nome)
        {
            Email = email;
            Nome = nome;
            Senha = senha;
            DataCadastro = DateTime.Now;
            Ativo = true;

            Validate(this, new UsuarioValidator());
        }

        public void AlterarSenha(string senha)
        {
            Senha = senha;
        }

        public void InativarUsuario()
        {
            Ativo = false;
        }

        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; set; }
        public ICollection<Retorno> Retornos { get; set;}
        public ICollection<RetornoHistorico> RetornosHistorico { get; set; }
    }
}
