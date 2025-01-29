
using BudgetControl.Application.Services;
using BudgetControl.Presentation.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Registrar serviços
builder.Services.AddSingleton<WeatherForecastService>();

// Configuração do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "BudgetControl API",
        Version = "v1",
        Description = "Uma API para controle de orçamento pessoal",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Igor Andrade",
            Email = "seuemail@exemplo.com",
            Url = new Uri("https://www.seusite.com")
        }
    });
});

var app = builder.Build();

app.UseSwagger(); // Ativa a geração do Swagger
app.UseSwaggerUI(); // Ativa a interface gráfica para visualizar a documentação
app.UseHttpsRedirection();
app.MapWeatherForecastEndpoints();

app.Run();