namespace Strategy_Refactoring.Models;

public class RookieArcher : IPlayer
{
    public int AttackDamage()
    {
        return 3;
    }

    public bool IsNeedToGenerate(int level, string weapon)
    {
        return level<10 && weapon == "bow";
    }
}