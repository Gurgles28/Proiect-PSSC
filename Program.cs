using Example.Domain.Repositories;
using Example.Domain.Workflows;
using Example.Infrastructure.Messaging;
using Example.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to DI
builder.Services.AddScoped<PlaceOrderWorkflow>();
builder.Services.AddScoped<GenerateInvoiceWorkflow>();
builder.Services.AddScoped<CreateShipmentWorkflow>();

builder.Services.AddSingleton<IOrderRepository, OrderRepository>();
builder.Services.AddSingleton<IInvoiceRepository, InvoiceRepository>();
builder.Services.AddSingleton<IShipmentRepository, ShipmentRepository>();

builder.Services.AddSingleton<IEventSender>(_ =>
    new AzureServiceBusEventSender(
        builder.Configuration["ServiceBus:ConnectionString"],
        builder.Configuration["ServiceBus:TopicName"]
    ));


// Add controllers
builder.Services.AddControllers();

var app = builder.Build();

// Map controllers
app.MapControllers();

app.Run();
