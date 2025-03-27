using Microsoft.AspNetCore.Mvc;
using MyFirstWebApplication.Objects;

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
    }
}