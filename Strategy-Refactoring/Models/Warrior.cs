namespace Strategy_Refactoring.Models;

public class Warrior : IPlayer
{
    public int AttackDamage()
    {
        return 24;
    }

    public bool IsNeedToGenerate(int level, string weapon)
    {
        return level >= 10 && weapon == "sword";
    }
}