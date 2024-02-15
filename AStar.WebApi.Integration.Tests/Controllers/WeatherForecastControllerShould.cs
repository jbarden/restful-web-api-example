using System.Text.Json;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

namespace AStar.WebApi.Integration.Tests;

public class WeatherForecastControllerShould
{
    [Fact]
    public async Task ReturnTheExpectedNumberOfForecasts()
    {
        var app = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder =>
            {
                // placeholder
            });

        var client = app.CreateClient();

        var response = await client.GetAsync("weatherForecast");

        response.EnsureSuccessStatusCode();
        var result = JsonSerializer.Deserialize<WeatherForecast[]>(await response.Content.ReadAsStringAsync());
        result.Length.Should().Be(5);
    }
}