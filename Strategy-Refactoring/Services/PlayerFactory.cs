using Strategy_Refactoring.Models;

namespace Strategy_Refactoring.Services;

public class PlayerFactory
{
    public IPlayer Get(int level, string weapon)
    {
        if (level >= 10)
        {
            if (weapon == "sword")
            {
                return new Warrior();
            }

            return new Archer();
        }

        return weapon switch
        {
            "sword" => new RookieWarrior(),
            "bow" => new RookieArcher(),
            _ => new Rookie()
        };
    }
}