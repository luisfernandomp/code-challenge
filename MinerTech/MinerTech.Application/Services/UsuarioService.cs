using FluentValidation;
using MinerTech.Application.Validators;
using MinerTech.Domain;
using MinerTech.Domain.Interfaces;
using MinerTech.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace MinerTech.Application.Services
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        public UsuarioService(IBaseRepository<Usuario> baseRepository) : base(baseRepository)
        {
        }

        

        public void AlterarSenha(int id, string novaSenha)
        {
            base.Add<UsuarioValidator>(new Usuario());


            throw new NotImplementedException();
        }

        public void Inativar(int id)
        {
            throw new NotImplementedException();
        }

        public UsuarioDto ObterUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioDto> ObterUsuariosAtivos()
        {
            throw new NotImplementedException();
        }
    }
}
