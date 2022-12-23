using FactoryTeamBot.Dtos;
using FactoryTeamBot.Enums;
using FactoryTeamBot.Services.Interfaces;

namespace FactoryTeamBot.Services;

public class InteractionService: IInteractionService
{
    
    private readonly IEaSimulatorService _eaSimulatorService;
    
    public InteractionService(IEaSimulatorService eaSimulatorService)
    {
        _eaSimulatorService = eaSimulatorService;
    }
    
    public InteractionCallbackDto<InteractionCallbackDataDto>? HandleInteraction(InteractionDto interaction)
    {
        try
        {
            if (interaction.Type == InteractionType.Ping)
                return HandlePing(interaction);

            _eaSimulatorService.DoSomething();

            return interaction.Data?.Name switch
            {
                "daily" => HandleDaily(),
                _ => null
            };
        }
        catch (Exception ex)
        {
            return new InteractionCallbackDto<InteractionCallbackDataDto>
            {
                Type = InteractionCallbackType.ChannelMessageWithSource,
                Data = new InteractionCallbackMessageDataDto
                {
                    Content = $"Error: {ex.Message}\n ```{ex.StackTrace}```"
                }
            };
        }
        
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