using MinerTech.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Interfaces
{
    public interface IUsuarioService
    {
        Task<ResponseApi> ObterUsuarioPorId(int id);
        Task<ResponseApi> ObterUsuariosAtivos(int page, int pageSize);
        Task<ResponseApi> AlterarSenha(int id, string novaSenha);
        string Criptografar(string valor);
        Task<ResponseApi> Inativar(int id);
        Task<ResponseApi> CadastrarUsuario(UsuarioDto usuario);
    }
}
