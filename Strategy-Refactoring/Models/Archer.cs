namespace Strategy_Refactoring.Models;

public class Archer : IPlayer
{
    public int AttackDamage()
    {
        return 12;
    }
}