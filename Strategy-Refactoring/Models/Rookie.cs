namespace Strategy_Refactoring.Models;

public class Rookie: IPlayer
{
    public int AttackDamage()
    {
        return 1;
    }
}