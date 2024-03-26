using Strategy_Refactoring.Models;

namespace Strategy_Refactoring.Services;

public class PlayerFactory
{
    private readonly List<IPlayer> _players =
    [
        new Archer(),
        new Warrior(),
        new RookieArcher(),
        new RookieWarrior()
    ];

    public IPlayer Get(int level, string weapon)
    {
        foreach (var player in _players)
        {
            if (player.IsNeedToGenerate(level, weapon))
            {
                return player;
            }
        }

        return new Rookie();
    }
}