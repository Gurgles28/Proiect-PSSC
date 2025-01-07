using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Proiect_PSSC.Data;
using Proiect_PSSC.Repos;
using Proiect_PSSC.Services;

namespace Proiect_PSSC.Config;

public static class AzureConfiguration
{
    public static void AddAzureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("AzureDb")));

        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IInvoiceRepository, InvoiceRepository>();
        services.AddScoped<IShipmentService, ShipmentService>();
    }
}