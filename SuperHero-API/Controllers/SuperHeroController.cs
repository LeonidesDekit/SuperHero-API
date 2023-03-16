using Microsoft.AspNetCore.Mvc;

namespace SuperHero_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHero()
        {
            return new List<SuperHero>
            {
                new SuperHero
                {
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City",
                }
            };
        }
    }
}
