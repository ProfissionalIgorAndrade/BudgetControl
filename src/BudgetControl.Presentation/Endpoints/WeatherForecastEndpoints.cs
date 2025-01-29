using BudgetControl.Application.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace BudgetControl.Presentation.Endpoints;

public static class WeatherForecastEndpoints
{
    public static void MapWeatherForecastEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/weatherforecast", (WeatherForecastService service) =>
        {
            return service.GetForecast();
        })
        .WithName("GetWeatherForecast");
    }
}
