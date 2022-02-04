using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers;

[ApiController]
[Route("[controller]")]
public class HolaMundoController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHolaMundo()
    {
        return Ok("Hello World Javier Tercera prueba");
    }
    
    //TODO: Crear un método post 
}