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

            return Ok(brugere);
        }
    }
}
