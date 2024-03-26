namespace Strategy_Refactoring.Models;

public class Rookie: IPlayer
{
    public int AttackDamage()
    {
        return 1;
    }

    public bool IsNeedToGenerate(int level, string weapon)
    {
        return level < 10;
    }
}