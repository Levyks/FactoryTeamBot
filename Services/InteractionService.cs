using FactoryTeamBot.Dtos;
using FactoryTeamBot.Enums;
using FactoryTeamBot.Services.Interfaces;

namespace FactoryTeamBot.Services;

public class InteractionService: IInteractionService
{
    public InteractionCallbackDto<InteractionCallbackDataDto>? HandleInteraction(InteractionDto interaction)
    {
        if (interaction.Type == InteractionType.Ping)
            return HandlePing(interaction);
        
        ;

        return null;
    }
    
    private InteractionCallbackDto<InteractionCallbackDataDto> HandlePing(InteractionDto interaction)
    {
        return new InteractionCallbackDto<InteractionCallbackDataDto>
        {
            Type = InteractionCallbackType.Pong
        };
    }
    
}