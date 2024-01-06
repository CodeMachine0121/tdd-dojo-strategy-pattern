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
        var result = _killerService.Kill();
        result.Should().Be("kill by knife");
    }
}