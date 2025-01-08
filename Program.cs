using Example.Domain.Workflows;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register workflows or any other dependencies.
builder.Services.AddTransient<PlaceOrderWorkflow>();


builder.Logging.AddConsole(); // Ensures logs are written to the console

var app = builder.Build();

// Map test endpoint.
app.MapGet("/", () => "API is working!");

// Map controllers.
app.MapControllers();

app.Run();