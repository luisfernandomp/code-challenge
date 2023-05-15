using Microsoft.AspNetCore.Mvc;
using MinerTech.Domain.Interfaces;
using MinerTech.Domain.Entities.Cargueiro.Dtos;

namespace MinerTech.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClasseController : ControllerBase
    {
        private readonly IClasseService _classeService;

        public ClasseController(IClasseService classeService)
        {
            _classeService = classeService;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> ObterClassePorId(int id)
        {
            var response = await _classeService.ObterPorId(id);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ObterTodos([FromQuery] int page, [FromQuery] int itensPerPage)
        {
            var response = await _classeService.ObterTodos(page, itensPerPage);
            return Ok(response);
        }

        [HttpGet("listar/{nome}")]
        public async Task<IActionResult> ObterPorNome([FromRoute] string nome, [FromQuery] int page, [FromQuery] int itensPerPage)
        {
            var response = await _classeService.ObterPorNome(nome, page, itensPerPage);
            return Ok(response);
        }

        [HttpPatch("alterar-descricao/{id:int}")]
        public async Task<IActionResult> AlterarDescricao([FromRoute] string descricao, [FromRoute] int id)
        {
            var response = await _classeService.AlterarDescricao(id, descricao);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar([FromBody] ClasseDto dto)
        {
            var response = await _classeService.Cadastrar(dto);
            return Ok(response);
        }

        [HttpPatch("inativar-classe/{id:int}")]
        public async Task<IActionResult> Inativar(int id)
        {
            var response = await _classeService.Inativar(id);
            return Ok(response);
        }
    }
}
