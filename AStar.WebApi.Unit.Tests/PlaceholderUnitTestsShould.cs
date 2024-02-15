using FluentAssertions;

namespace AStar.WebApi.Unit.Tests;

public class PlaceholderUnitTestsShould
{
    [Fact]
    public void ReturnTrueToConfirmTestsWorking() => true.Should().BeTrue();
}