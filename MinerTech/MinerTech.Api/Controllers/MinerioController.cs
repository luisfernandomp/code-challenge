using Microsoft.AspNetCore.Mvc;
using MinerTech.Application.Services;
using MinerTech.Domain;
using MinerTech.Domain.Entities.Cargueiro.Dtos;
using MinerTech.Domain.Interfaces;

namespace MinerTech.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MinerioController : ControllerBase
    {
        private IMinerioService _minerioService;
        public MinerioController(IMinerioService minerioService)
        {
            _minerioService = minerioService;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var response = await _minerioService.ObterPorId(id);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ObterTodos([FromQuery] int page, [FromQuery] int itensPerPage)
        {
            var response = await _minerioService.ObterTodos(page, itensPerPage);
            return Ok(response);
        }

        [HttpGet("listar/{codigoOuCaracteristica}")]
        public async Task<IActionResult> ObterPorCodigoOuCaracteristica([FromRoute] string codigoOuCaracteristica, [FromQuery] int page, [FromQuery] int itensPerPage)
        {
            var response = await _minerioService.ObterPorCodigoOuCaracteristica(codigoOuCaracteristica, page, itensPerPage);
            return Ok(response);
        }

        [HttpPatch("alterar-descricao/{id:int}")]
        public async Task<IActionResult> AlterarDescricao([FromRoute] string descricao, [FromRoute] int id)
        {
            var response = await _minerioService.AlterarCaracteristica(id, descricao);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar([FromBody] MinerioDto dto)
        {
            var response = await _minerioService.Cadastrar(dto);
            return Ok(response);
        }

        [HttpPatch("inativar-minerio/{id:int}")]
        public async Task<IActionResult> Inativar(int id)
        {
            var response = await _minerioService.Inativar(id);
            return Ok(response);
        }
    }
}
