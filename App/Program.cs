var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return Results.Ok(new { message = "Hello World!" });
});

app.Run();
