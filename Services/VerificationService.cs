using System.Text;
using FactoryTeamBot.Dtos;
using FactoryTeamBot.Services.Interfaces;

namespace FactoryTeamBot.Services;

public class VerificationService: IVerificationService
{
    private static readonly string PublicKey = Environment.GetEnvironmentVariable("DISCORD_PUBLIC_KEY")!;
    public async Task<bool> VerifyInteraction(HttpRequest request)
    {
        var signature = request.Headers["X-Signature-Ed25519"].ToString();
        var timestamp = request.Headers["X-Signature-Timestamp"].ToString();
        
        request.Body.Position = 0;
        using var stream = new StreamReader(request.Body);
        var bodyStr = await stream.ReadToEndAsync();

        var payload = timestamp + bodyStr;

        return TweetNaclSharp.NaclFast.SignDetachedVerify(
            Encoding.ASCII.GetBytes(payload),
            Convert.FromHexString(signature),
            Convert.FromHexString(PublicKey)
        );
    }
    
}