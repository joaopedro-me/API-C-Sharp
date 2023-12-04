using Teste.csproj;

namespace Users.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    [HttpGet("/Script")]
    public IActionResult GetAll()
        => Ok(User.Users.ToList());
    
}

    [HttpGet("/{id}")]
    public IActionResult GetById ([FromRoute] int id){   

        var User = User.Users.FirstOrDefault(x => x.id == id);

        if (User == null){
            return Notfound();
        }

        return ok(User);
    }

    [HttpPost("/Script")]
    public IActionResult add([FromBody] User user)
    {
        User.Users.add(user);

        return NoContent();
    }

    [HttpDelete("/{id}")]
    public IActionResult delete([FromRoute] int id)
    {
        var User = User.Users.FirstOrDefault(x => x.id == id);
        if (User == null){
            return Notfound();
        }

        return ok(User);

    }

    [HttpPut("/{id}")]
    public IActionResult update([FromRoute] int id,[FromBody] User user)
    {
        var UserU = User.Users.FirstOrDefault(x => x.id == id);
        
    }