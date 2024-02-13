using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Super ça marche ton truc");
        }
    }
}
