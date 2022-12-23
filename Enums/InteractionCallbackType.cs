namespace FactoryTeamBot.Enums;

public enum InteractionCallbackType
{
    Pong = 1,
    ChannelMessageWithSource = 4,
    DeferredChannelMessageWithSource = 5,
    DeferredUpdateMessage = 6,
    UpdateMessage = 7,
    ApplicationCommandAutoCompleteResult = 8,
    Modal = 9,
}