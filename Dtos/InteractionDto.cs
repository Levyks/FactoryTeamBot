using FactoryTeamBot.Enums;

namespace FactoryTeamBot.Dtos;

public class InteractionDto
{
    public string ApplicationId { get; set; } = null!;
    public string Id { get; set; }
    public string Token { get; set; } = null!;
    public UserDto? User { get; set; } = null!;
    public InteractionType Type { get; set; }
    public int Version { get; set; }
}