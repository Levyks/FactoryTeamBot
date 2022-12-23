using FactoryTeamBot.Dtos;

namespace FactoryTeamBot.Services.Interfaces;

public interface IInteractionService
{
    InteractionCallbackDto<InteractionCallbackDataDto>? HandleInteraction(InteractionDto interaction);
}