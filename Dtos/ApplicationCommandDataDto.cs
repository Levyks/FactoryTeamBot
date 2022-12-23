using FactoryTeamBot.Enums;

namespace FactoryTeamBot.Dtos;

public class ApplicationCommandDataDto
{
    public String Id { get; set; }
    public String Name { get; set; }
    public ApplicationCommandType Type { get; set; }
}