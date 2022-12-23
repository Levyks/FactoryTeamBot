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

        return interaction.Data?.Name switch
        {
            "daily" => HandleDaily(),
            _ => null
        };
    }
    
    private InteractionCallbackDto<InteractionCallbackDataDto> HandleDaily()
    {
        
        return new InteractionCallbackDto<InteractionCallbackDataDto>
        {
            Type = InteractionCallbackType.ChannelMessageWithSource,
            Data = new InteractionCallbackMessageDataDto
            {
                Content = "Daily"
            }
        };
    }
    
    private InteractionCallbackDto<InteractionCallbackDataDto> HandlePing(InteractionDto interaction)
    {
        return new InteractionCallbackDto<InteractionCallbackDataDto>
        {
            Type = InteractionCallbackType.Pong
        };
    }
    
}