using FactoryTeamBot.Enums;

namespace FactoryTeamBot.Dtos;

public class InteractionCallbackDto<T> where T : InteractionCallbackDataDto
{
    public InteractionCallbackType Type { get; set; }
    public T Data { get; set; }
}