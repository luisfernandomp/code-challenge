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
        [Route("id:int")]
        public IActionResult ObterUsuarioPorId([FromQuery] int id)
        {
            return Ok("Olá mundo");
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult ObterUsuariosAtivos()
        {
            return Ok("Olá mundo");
        }

        [HttpPatch]
        [Route("alterar-senha/id:int")]
        public IActionResult AlterarSenha([FromBody] UsuarioDto usuario)
        {
            return Ok("Olá mundo");
        }

        [HttpPost]
        [Route("alterar-senha")]
        public IActionResult CadastrarUsuario([FromBody] UsuarioDto usuario)
        {
            return Ok("Olá mundo");
        }

        [HttpPatch]
        [Route("inativar-usuario/id:int")]
        public IActionResult Inativar([FromQuery] int id)
        {
            return Ok("Olá mundo");
        }
    }
}
