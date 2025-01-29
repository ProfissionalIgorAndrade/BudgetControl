using BudgetControl.Domain;

namespace BudgetControl.Application.Services;

public class WeatherForecastService
{
    private readonly string[] _summaries =
    {
        "Macarrão", "Arroz", "Feijão", "Bife", "Lentilha"
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
