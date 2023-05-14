using AutoMapper;
using FluentValidation;
using MinerTech.Application.Validators;
using MinerTech.Domain;
using MinerTech.Domain.Entities;
using MinerTech.Domain.Entities.Usuario.Dto;
using MinerTech.Domain.Interfaces;
using MinerTech.Domain.Response;

namespace MinerTech.Application.Services
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        public UsuarioService(IBaseRepository<Usuario> baseRepository,
            NotificationContext notificationContext,
            IMapper mapper) : 
            base(baseRepository, notificationContext, mapper)
        { }

        public async Task AlterarSenha(int id, string novaSenha)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseApi> CadastrarUsuario(UsuarioDto dto)
        {
            var usuario = new Usuario(
                dto.Email,
                BCrypt.Net.BCrypt.HashPassword(dto.Senha), 
                dto.Nome);

            if (usuario.Invalid)
            {
                _notificationContext.AddNotifications(usuario.ValidationResult);
                return new ResponseApi();
            }

            await Add(usuario);
            return new ResponseApi(true, "Usuário cadastrado com sucesso!");
        }

        public async Task Inativar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseApi> ObterUsuarioPorId(int id)
        {
            var result = await GetById(id);

            var response = _mapper.Map<UsuarioResponseDto>(result);

            return new ResponseApi(true, "", response);

        }

        public async Task<ResponseApi> ObterUsuariosAtivos(int page, int itensPerPage)
        {
            var result = await GetPaged(List().Where(u => u.Ativo), page, itensPerPage);

            var response = result.Results.Select(_mapper.Map<UsuarioResponseDto>).ToList();

            result.ToDto(response
                        .Cast<object>()
                        .ToList());

            return new ResponseApi(true, "", result);
        }
    }
}
