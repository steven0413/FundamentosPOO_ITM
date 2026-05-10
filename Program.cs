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

app.MapGet("/circle-perimeter/{radius}", (double radius) =>
{
    var service = new MathService();

    var resultado = service.CirclePerimeter(radius);

    return Results.Ok(new
    {
        radius = radius,
        resultado = resultado
    });
});

app.MapGet("/midweek-day/{day}", (int day) =>
{
    var service = new MathService();

    var resultado = service.MidweekDay(day);

    return Results.Ok(new
    {
        input = day,
        resultado = resultado
    });
});

app.MapGet("/tax-calculator/{salary}", (double salary) =>
{
    var service = new MathService();

    var resultado = service.TaxCalculator(salary);

    return Results.Ok(new
    {
        salary = salary,
        resultado = resultado
    });
});

app.MapGet("/remainder-finder/{a}/{b}", (int a, int b) =>
{
    var service = new MathService();

    var resultado = service.RemainderFinder(a, b);

    return Results.Ok(new
    {
        inputA = a,
        inputB = b,
        resultado = resultado
    });
});

app.MapGet("/sum-of-evens", () =>
{
    var service = new MathService();

    var resultado = service.SumOfEvens();

    return Results.Ok(new
    {
        resultado = resultado
    });
});

app.MapGet("/fraction-difference/{a}/{b}/{c}/{d}",
    (int a, int b, int c, int d) =>
{
    var service = new MathService();

    var resultado = service.FractionDifference(a, b, c, d);

    return Results.Ok(new
    {
        fraction1 = $"{a}/{b}",
        fraction2 = $"{c}/{d}",
        resultado = resultado
    });
});

app.MapGet("/string-length/{word}", (string word) =>
{
    var service = new MathService();

    var resultado = service.StringLength(word);

    return Results.Ok(new
    {
        palabra = word,
        longitud = resultado
    });
});

app.MapGet("/average-of-four/{a}/{b}/{c}/{d}",
    (double a, double b, double c, double d) =>
    {
        var service = new MathService();

        var resultado = service.AverageOfFour(a, b, c, d);

        return Results.Ok(new
        {
            numeros = new[] { a, b, c, d },
            promedio = resultado
        });
    });

app.MapGet("/smallest-of-five/{a}/{b}/{c}/{d}/{e}",
    (int a, int b, int c, int d, int e) =>
    {
        var service = new MathService();

        var resultado = service.SmallestOfFive(a, b, c, d, e);

        return Results.Ok(new
        {
            numeros = new[] { a, b, c, d, e },
            menor = resultado
        });
    });

app.MapGet("/vowel-counter/{word}", (string word) =>
{
    var service = new MathService();

    var resultado = service.VowelCounter(word);

    return Results.Ok(new
    {
        palabra = word,
        vocales = resultado
    });
});

app.MapGet("/factorial-finder/{number}", (int number) =>
{
    var service = new MathService();

    var resultado = service.FactorialFinder(number);

    return Results.Ok(new
    {
        numero = number,
        factorial = resultado
    });
});


app.Run();



internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
