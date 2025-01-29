
using BudgetControl.Application.Services;
using BudgetControl.Presentation.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Registrar serviços
builder.Services.AddSingleton<WeatherForecastService>();

// Configuração do Swagger
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


app.UseHttpsRedirection();

// Mapeamento dos Endpoints
app.MapWeatherForecastEndpoints();

app.Run();