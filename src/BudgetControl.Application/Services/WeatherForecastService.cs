using BudgetControl.Domain;

namespace BudgetControl.Application.Services;

public class WeatherForecastService
{
    private readonly string[] _summaries =
    {
        "Igor", "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm",
        "Balmy", "Hot", "Sweltering", "Scorching", "Andreza", "Iago"
    };

    public IEnumerable<WeatherForecast> GetForecast()
    {
        return Enumerable.Range(1, 5).Select(index =>
            new WeatherForecast(
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Random.Shared.Next(-20, 55),
                _summaries[Random.Shared.Next(_summaries.Length)]
            ));
    }
}
