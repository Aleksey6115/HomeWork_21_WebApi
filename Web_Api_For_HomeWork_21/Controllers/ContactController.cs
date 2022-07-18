using Microsoft.AspNetCore.Mvc;
using Persistence;
using Application;
using Domain.Contact;

namespace Web_Api_For_HomeWork_21.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class ContactController : Controller
    {
        #region Инициализация данных
        private IRepository<Contact> _contactRepository;

        public ContactController(IRepository<Contact> repository) { _contactRepository = repository; }
        #endregion


        [HttpGet]
        [Route ("Work")]
        public IActionResult Work()
        {
            return Ok("this service is work!");
        }

        [HttpGet]
        [Route ("Test")]
        public IActionResult Test() => Ok(_contactRepository.GetAll());
    }
}
