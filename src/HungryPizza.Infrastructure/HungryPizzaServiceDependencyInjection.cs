using HungryPizza.Domain.Interfaces.Services;
using HungryPizza.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HungryPizza.Infrastructure
{
    public static class HungryPizzaServiceDependencyInjection
    {
        public static void AddHungryPizzaServiceDependencyInjection(this IServiceCollection service)
        {
            service.AddScoped<IPedidoService, PedidoService>();
            service.AddScoped<IOpcaoPizzaService, OpcaoPizzaService>();
        }
    }
}
