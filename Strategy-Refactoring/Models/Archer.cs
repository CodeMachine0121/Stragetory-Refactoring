namespace Strategy_Refactoring.Models;

public class Archer : IPlayer
{
    public int AttackDamage()
    {
        return 12;
    }

    public bool IsNeedToGenerate(int level, string weapon)
    {
        return level>=10 && weapon == "bow";
    }
}