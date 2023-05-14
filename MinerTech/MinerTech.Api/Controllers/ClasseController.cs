using Microsoft.AspNetCore.Mvc;
using MinerTech.Domain.Interfaces;

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

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
