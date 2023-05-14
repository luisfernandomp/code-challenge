using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
