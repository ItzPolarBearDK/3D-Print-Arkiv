using _3_D_Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace _3_D_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class _3_DController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllBrugere()
        {
            var brugere = new List<Bruger> {
                new Bruger
            {
                id = 1,
                name = "Erik",
                password = "Bent"
            }
        };
            [HttpPost]
            public async Task<ActionResult<List<Bruger>>> AddUser (Bruger bruger)
            {

                _context.Brugere.Add(bruger);

                await _context.SaveChangesAsync();


                return Ok(await GetAllBrugere());
            }
        }
    }
}
