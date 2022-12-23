namespace FactoryTeamBot.Dtos;

public class AllowedMentionsDto
{
    public List<string>? Parse { get; set; }
    public List<string>? Roles { get; set; }
    public List<string>? Users { get; set; }
    public bool? RepliedUser { get; set; } 
}