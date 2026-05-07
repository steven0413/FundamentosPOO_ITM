using FundamentosPOO_ITM.Domain.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.MapGet("/positive-power/{num}", (int num) =>
{
    var service = new MathService();
    var resultado = service.PositivePower(num);

    return Results.Ok(new { input = num, resultado = resultado });
});

app.MapGet("/double-or-triple/{a}/{b}", (int a, int b) =>
{
    var service = new MathService();

    var resultado = service.DoubleOrTriple(a, b);

    return Results.Ok(new
    {
        inputA = a,
        inputB = b,
        resultado = resultado
    });
});

app.MapGet("/root-or-square/{num}", (int num) =>
{
    var service = new MathService();

    var resultado = service.RootOrSquare(num);

    return Results.Ok(new
    {
        input = num,
        resultado = resultado
    });
});


app.Run();



internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
