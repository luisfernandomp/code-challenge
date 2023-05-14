using Microsoft.AspNetCore.Mvc;
using MinerTech.Domain.Interfaces;

namespace MinerTech.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargueiroController : ControllerBase
    {
        private readonly ICargueiroService _cargueiroService;
        public CargueiroController(ICargueiroService cargueService)
        {
            _cargueiroService= cargueService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
