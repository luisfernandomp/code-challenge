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

        public async Task<ResponseApi> AlterarSenha(int id, string novaSenha)
        {
            var usuario = await GetById(id);

            if(usuario == null)
            {
                _notificationContext.AddNotification("Usuário", "Não foi possível encontrar nenhum usuário com o Id informado");
                return new ResponseApi();
            }

            usuario.AlterarSenha(Criptografar(novaSenha));

            return new ResponseApi(true, "Senha alterada com sucesso!");
        }

        public async Task<ResponseApi> CadastrarUsuario(UsuarioDto dto)
        {
            var usuario = new Usuario(
                dto.Email,
                Criptografar(dto.Senha), 
                dto.Nome);

            if (usuario.Invalid)
            {
                _notificationContext.AddNotifications(usuario.ValidationResult);
                return new ResponseApi();
            }

            await Add(usuario);
            return new ResponseApi(true, "Usuário cadastrado com sucesso!");
        }

        public async Task<ResponseApi> Inativar(int id)
        {
            var usuario = await GetById(id);

            if (usuario == null)
            {
                _notificationContext.AddNotification("Usuário", "Não foi possível encontrar nenhum usuário com o Id informado");
                return new ResponseApi();
            }

            usuario.InativarUsuario();

            return new ResponseApi(true, "Usuário inativado com sucesso!");
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

        public string Criptografar(string valor)
        {
            return BCrypt.Net.BCrypt.HashPassword(valor);
        }
    }
}
