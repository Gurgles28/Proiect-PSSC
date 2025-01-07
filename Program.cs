using Microsoft.AspNetCore.Builder;
using Proiect_PSSC.Config;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAzureServices(builder.Configuration);

var app = builder.Build();
app.Run();