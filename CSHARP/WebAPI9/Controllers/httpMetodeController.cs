using Microsoft.AspNetCore.Mvc;
using WebAPI9.Models;

namespace WebAPI9.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class httpMetodeController : ControllerBase
    {


        // pocinje ruta 

        // ruta je motoda 
        [HttpGet]
        
        public string HelloWorld()
        {
            return "HelloWorld";
        }

        // zavrsava ruta

        // pocinje ruta 

        [HttpGet]
        [Route("HelloWolrd")]
        public string HelloWorld(string ime)
        {
            return $"Hello {ime}!";
        }
        //zavrsava ruta 


        //pocinje ruta

        [HttpGet]
        [Route("json")]
        public IActionResult Json(int sifra, string ime)
        {
            return Ok(new { Sifra = sifra, Ime = ime });
        }

        //zavrsava ruta



        //pocinje ruta 

        [HttpPost]
        public IActionResult Post(Osoba osoba)
        {
            osoba.Ime = "hello" + osoba.Ime;
            return StatusCode( 201, osoba);
        }
        //zavrsava ruta


        //pocinje ruta


        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            osoba.Ime = "Hello " + osoba.Ime;
            return StatusCode(StatusCodes.Status206PartialContent);
        }
        // zavrsava ruta 


        [HttpDelete]
        public IActionResult Delete(int sifra)
        {
            if(sifra <= 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { poruka = "Sifra mora biti veca o 0" });

            }
            return StatusCode(StatusCodes.Status400BadRequest);
        }

    }


}
