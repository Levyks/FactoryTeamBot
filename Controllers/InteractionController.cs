using FactoryTeamBot.Dtos;
using FactoryTeamBot.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FactoryTeamBot.Controllers;


[ApiController]
[Route("[controller]")]
public class InteractionController : ControllerBase
{
    private readonly IInteractionService _interactionService;
    
    public InteractionController(IInteractionService interactionService)
    {
        _interactionService = interactionService;
    }
    
    [HttpPost]
    public InteractionCallbackDto<InteractionCallbackDataDto>? Post([FromBody] InteractionDto interaction)
    {
        return _interactionService.HandleInteraction(interaction);
    }
    
}