using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Data;
using SchoolProject.Models;
using SchoolProject.Objects;
using SchoolProject.Objects;

namespace MyFirstWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Schulcontroller : ControllerBase
    {
        private static Schule schule = new Schule();
        [HttpGet("AlleSchueler")]
        public ActionResult<List<Schueler>> AllStudents()
        {
            return Ok(schule.SchuelerList);
        }

        [HttpPost("AddSchueler")]
        public IActionResult AddSchueler([FromBody] Schueler neuerSchueler)
        {
            schule.AddSchuelerToSchule(neuerSchueler);
            return Ok(new { schueler = neuerSchueler });
        }

        [HttpGet("Durchschnittsalter")]
        public IActionResult Durchschnittsalter()
        {
            return Ok(new { Durchschnittsalter = schule.DurchschnittsalterSchueler() });
        }

        [HttpGet("Geschlecht")]
        public IActionResult Geschlechter()
        {
            return Ok(new { verteilung = schule.AnzahlSchülerGeschlecht });
        }

        [ApiController]
        [Route("[controller]")]
        public class SchoolController : ControllerBase
        {
            private readonly SchoolContext _context;

            public SchoolController(SchoolContext context)
            {
                _context = context;
            }
    
            [HttpPost("Lehrer")]
            public IActionResult AddLehrer([FromBody] Lehrer lehrer)
            {
                _context.Lehrer.Add(lehrer);
                _context.SaveChanges();
                return Ok(lehrer);
            }

            [HttpGet("Lehrer")]
            public IActionResult GetLehrer()
            {
                var alle = _context.Lehrer.ToList();
                return Ok(alle);
            }

        }
    }

}

    