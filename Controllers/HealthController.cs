using FactoryTeamBot.Dtos;
using FactoryTeamBot.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FactoryTeamBot.Controllers;


[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public ActionResult Index()
    {
        return Ok(new
        {
            message = "I'm alive!"
        });
    }
    
}