namespace FactoryTeamBot.Dtos;

public class InteractionCallbackMessageDataDto: InteractionCallbackDataDto
{
    public bool? Tts { get; set; }
    public string? Content { get; set; }
    public List<EmbedDto>? Embeds { get; set; }
    public AllowedMentionsDto? AllowedMentions { get; set; }
    public int? Flags { get; set; }
}