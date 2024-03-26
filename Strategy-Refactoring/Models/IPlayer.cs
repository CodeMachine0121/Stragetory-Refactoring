namespace Strategy_Refactoring.Models;

public interface IPlayer
{
    public int AttackDamage();
    public bool IsNeedToGenerate(int level, string weapon);
}