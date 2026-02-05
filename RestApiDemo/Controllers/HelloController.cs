using Microsoft.AspNetCore.Mvc;

namespace RestApiDemo.Controllers
{
    [ApiController]
    [Route("api/hello")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult SayHello()
        {
            return Ok("Hello from ASP.NET Core API");
        }
    }
}
