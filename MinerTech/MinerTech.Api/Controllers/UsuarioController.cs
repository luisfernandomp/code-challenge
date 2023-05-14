using Microsoft.AspNetCore.Mvc;
using MinerTech.Domain;
using MinerTech.Domain.Interfaces;

namespace MinerTech.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService= usuarioService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> ObterUsuarioPorId(int id)
        {
            var response = await _usuarioService.ObterUsuarioPorId(id);
            return Ok(response);
        }

        [HttpGet]
        [Route("listar-ativos")]
        public async Task<IActionResult> ObterUsuariosAtivos([FromQuery] int page, [FromQuery] int itensPerPage)
        {
            var response = await _usuarioService.ObterUsuariosAtivos(page, itensPerPage);
            return Ok(response);
        }

        [HttpPatch]
        [Route("alterar-senha/{id}")]
        public IActionResult AlterarSenha([FromBody] UsuarioDto usuario, [FromRoute] int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario([FromBody] UsuarioDto dto)
        {
            var response = await _usuarioService.CadastrarUsuario(dto);
            return Ok(response);
        }

        [HttpPatch]
        [Route("inativar-usuario/{id}")]
        public IActionResult Inativar(int id)
        {
            return Ok();
        }
    }
}
