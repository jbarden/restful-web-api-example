using System.Text.Json;
using FluentAssertions;

namespace AStar.WebApi.Unit.Tests;

public class WeatherForecastModelShould
{
    [Fact]
    public void ContainTheExpectedProperties()
    {
        var sut = new WeatherForecast();

        var serialised = JsonSerializer.Serialize(sut);

        serialised.Should().Be("{\"Date\":\"0001-01-01\",\"TemperatureC\":0,\"TemperatureF\":32,\"Summary\":null}");
    }
}