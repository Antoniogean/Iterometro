using Microsoft.AspNetCore.Mvc;

namespace Iterometro.WebAPI.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class IterometroController : ControllerBase
    {
        [HttpGet]

        public IActionResult Index()
        {
            return Ok();
        }
    }
}
