using FluentAssertions;
using Strategy_Refactoring.Models;
using Strategy_Refactoring.Services;

namespace Strategy_Refactoring;

public class Tests
{
    private PlayerFactory _playerFactory;

    [SetUp]
    public void SetUp()
    {
        _playerFactory = new PlayerFactory();
    }


    [Test]
    public void should_become_archer_when_level_is_10_and_use_bow()
    {
        _playerFactory.Get(10, "bow").Should().BeOfType<Archer>();
    }

    [Test]
    public void should_become_warrior_when_level_is_10_and_use_sword()
    {
        _playerFactory.Get(10, "sword").Should().BeOfType<Warrior>();
    }

    [Test]
    public void should_become_rookie_when_level_is_below_10()
    {
        _playerFactory.Get(9, "").Should().BeOfType<Rookie>();
    }

    [Test]
    public void should_become_rookie_warrior_when_level_is_below_10_and_use_sword()
    {
        _playerFactory.Get(9, "sword").Should().BeOfType<RookieWarrior>();
    }

    [Test]
    public void should_become_rookie_archer_when_level_is_below_10_and_use_sword()
    {
        _playerFactory.Get(9, "bow").Should().BeOfType<RookieArcher>();
    }
}