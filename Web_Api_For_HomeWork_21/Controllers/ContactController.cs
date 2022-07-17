using Microsoft.AspNetCore.Mvc;

namespace Web_Api_For_HomeWork_21.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class ContactController : Controller
    {
        [HttpGet]
        [Route ("Work")]
        public IActionResult Work()
        {
            return Ok("this service is work!");
        }

        [HttpGet]
        [Route ("Test")]
        public IActionResult Test()
        {
            return Ok("Test is succes");
        }
    }
}
