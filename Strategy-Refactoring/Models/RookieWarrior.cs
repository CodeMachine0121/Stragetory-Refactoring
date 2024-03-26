namespace Strategy_Refactoring.Models;

public class RookieWarrior : IPlayer
{
    public int AttackDamage()
    {
        return 2;
    }

    public bool IsNeedToGenerate(int level, string weapon)
    {
        return level < 10 && weapon == "sword";
    }
}