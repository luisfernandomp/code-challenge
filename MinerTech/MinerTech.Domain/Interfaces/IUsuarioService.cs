using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Interfaces
{
    public interface IUsuarioService
    {
        UsuarioDto ObterUsuarioPorId(int id);
        List<UsuarioDto> ObterUsuariosAtivos();
        void AlterarSenha(int id, string novaSenha);
        void Inativar(int id);
    }
}
