using Microsoft.AspNetCore.Mvc;
using MinerTech.Domain.Interfaces;

namespace MinerTech.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetornoController : ControllerBase
    {
        private readonly IRetornoService _retornoService;
        public RetornoController(IRetornoService retornoService)
        {
            _retornoService = retornoService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
