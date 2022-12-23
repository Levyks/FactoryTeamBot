using FactoryTeamBot.Services.Interfaces;

namespace FactoryTeamBot.Services;

public class EaSimulatorService: IEaSimulatorService
{
    public void DoSomething()
    {
        var random = new Random();

        var number = random.Next(0, 5);
        if (number == 0)
        {
            string somethingNull = null!;
            Console.WriteLine(somethingNull.Length);
        } else if (number == 1)
        {
            throw new Exception("Erro de data e base");
        }
    }
}