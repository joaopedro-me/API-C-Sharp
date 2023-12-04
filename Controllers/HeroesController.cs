using HeroDTO;

namespace ApiHero
{

[ApiController]

public class MegaHero : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll() 
        => Ok(HeroDTO.DTO())

    

 
    [HttpGet("/id")]
    public IActionResult GetById([FromRoute] int id)
    {
        var hero = HeroDTO.DTO.FirstOrDefault(hero => hero.id == id);

        if(hero == null)
        {
            return Notfound(hero);
        }

        return ok(Hero);
    }

    [HttpPost("/id")]
    public IActionResult add([FromRoute] int id)
    {
        if (hero.id == id)
        {
            HeroDTO.DTO.add();
            return Ok(HeroDTO);
        }

        return NoContent(HeroDTO.DTO());
    }

    [HttpDelete("/id")]
    public IActionResult delete([FromRoute] int id)
    {
        if(hero.id = id)
        {
            heroDTO.DTO.delete(DTO);
            return Ok(delete);
        }
    }











}
}