using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Numbers : ControllerBase
    {
        [HttpPost("increment")]
        public ActionResult<int> Increment([FromBody] int number)
        {
            return Ok(number + 1);
        }

        [HttpPut("Sum")]
        public ActionResult<int> Increment1([FromBody] Sum sum)
        {
            return Ok(sum.ZahlA + sum.ZahlB);
        }
    }
}