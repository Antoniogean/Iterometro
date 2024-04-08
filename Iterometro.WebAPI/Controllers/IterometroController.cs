using Microsoft.AspNetCore.Mvc;

namespace Iterometro.WebAPI.Controllers
{
    public class IterometroController : ControllerBase
    {
        [HttpGet]

        public IActionResult Index()
        {
            return Ok();
        }
    }
}
