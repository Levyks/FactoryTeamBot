using FactoryTeamBot.Dtos;

namespace FactoryTeamBot.Services.Interfaces;

public interface IVerificationService
{
    Task<bool> VerifyInteraction(HttpRequest request);
}