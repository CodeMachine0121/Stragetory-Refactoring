using Strategy_Refactoring.Models;

namespace Strategy_Refactoring.Services;

public class PlayerFactory
{
    public IPlayer Get(int level, string weapon)
    {
        var playerValidators = GeneratePlayerValidators(level, weapon);

        return  playerValidators.First(x => x.IsNeedToGenerate).Value();
    }

    private static List<PlayerValidator> GeneratePlayerValidators(int level, string weapon)
    {
        var playerValidators = new List<PlayerValidator>()
        {
            new()
            {
                IsNeedToGenerate = level >= 10 && weapon == "sword",
                Value = () => new Warrior()
            },
            new()
            {
                IsNeedToGenerate = level >= 10 && weapon == "bow",
                Value = () => new Archer()
            },
            new()
            {
                IsNeedToGenerate = level < 10 && weapon == "sword",
                Value = () => new RookieWarrior()
            },
            new()
            {
                IsNeedToGenerate = level < 10 && weapon == "bow",
                Value = () => new RookieArcher()
            },
            new()
            {
                IsNeedToGenerate = true,
                Value = () => new Rookie()
            }
        };
        return playerValidators;
    }
}

public class PlayerValidator
{
    public bool IsNeedToGenerate { get; set; }
    public Func<IPlayer> Value { get; set; }
}