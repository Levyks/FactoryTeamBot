using FactoryTeamBot.Dtos;
using FactoryTeamBot.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FactoryTeamBot.Controllers;


[ApiController]
[Route("[controller]")]
public class InteractionController : ControllerBase
{
    private readonly IInteractionService _interactionService;    
    private readonly IVerificationService _verificationService;

    public InteractionController(IInteractionService interactionService, IVerificationService verificationService)
    {
        _interactionService = interactionService;
        _verificationService = verificationService;
    }
    
    [HttpPost]
    public async Task<ActionResult<InteractionCallbackDto<InteractionCallbackDataDto>?>> Post([FromBody] InteractionDto interaction)
    {
        if (!await _verificationService.VerifyInteraction(Request))
            return Unauthorized();

        return _interactionService.HandleInteraction(interaction);
    }
    
}