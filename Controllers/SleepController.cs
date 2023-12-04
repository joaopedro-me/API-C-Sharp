namespace Sleeps.Controllers;

[ApiController]
public class SleepController : ControllerBase
{
    [HttpGet("/Sleeps")]
    public IActionResult GetAll()
        => Ok(Sleeps.sleeps.ToList());
    
}