using CRUDCSharpWebApi.Entities;
using CRUDCSharpWebApi.Persistence;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CRUDCSharpWebApi.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly DevEventsDbContext _context;

        public HomeController(DevEventsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var  
        }
       

    }
}
