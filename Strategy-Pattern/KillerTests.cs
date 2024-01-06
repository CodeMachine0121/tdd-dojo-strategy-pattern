using FluentAssertions;
using NUnit.Framework;
using Strategy_Pattern.Service;

namespace Strategy_Pattern;

[TestFixture]
public class KillerTests
{
    private KillerService _killerService;

    [SetUp]
    public void SetUp()
    {
        _killerService = new KillerService();
    }

    [Test]
    public void should_kill_by_knife()
    {
        var result = _killerService.Kill("knife");
        result.Should().Be("kill by knife");
    }

    [Test]
    public void should_kill_by_gun()
    {
        var result = _killerService.Kill("gun");
        result.Should().Be("kill by gun");
    }

    [Test]
    public void should_kill_by_poison()
    {
       _killerService.Kill("poison").Should().Be("kill by poison");
    }
}