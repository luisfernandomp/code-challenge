using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class UsuarioDto
    {
        public UsuarioDto(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
