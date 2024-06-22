using Microsoft.AspNetCore.Mvc;

namespace DTOcw;

[Route("api/controller")]
[ApiController]
public class SuperHeroController : ControllerBase
{

    private static List<SuperHero> heroes = new List<SuperHero>
    {
        new SuperHero
        {
            Id = 1,
            Name = "asd",
            FirstName = "asd",
            LastName = "asd",
            Place = "asd",
            DateAdded = new DateTime(2001, 08, 10)
        },
        new SuperHero
        {
            Id = 2,
            Name = "xyz",
            FirstName = "xyz",
            LastName = "xyz",
            Place = "xyz",
            DateAdded = new DateTime(2021, 08, 10)
        }
    };

    [HttpGet]
    public ActionResult<List<SuperHero>> GetHeroes()
    {
        return heroes;
    }
}