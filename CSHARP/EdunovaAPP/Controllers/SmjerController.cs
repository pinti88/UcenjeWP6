using EdunovaAPP.Data;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController : ControllerBase
    {
        // Koristimi dependency injection
        // 1. definiramo privatno svojstvo

        private readonly EdunovaContext _context;

        // // Koristimi dependency injection
        // 2. prosljedis instancu kroz konstruktor

        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Smjerovi);

            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }




    }
}
