using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class MyFirstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Renata";

    // uma api acha que todo método público deve ser um endpoint,
    // então trocamos para protected para que a calsse derivada possa
    // acessar e o controller ache que o método é um endpoint 
    protected string getCustomKey()
    {
        var key = Request.Headers["MyKey"].ToString();
        return key;
    }

    // precisamos colocar uma rota para não conflitar com os endpoint da classe derivada
    [HttpGet("healthy")]
    public IActionResult Healthy()
    {
        return Ok("It's working");
    }
}
