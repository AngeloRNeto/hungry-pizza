using HungryPizza.Data.Repositories;
using HungryPizza.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HungryPizza.Data
{
    public static class HungryPizzaRepositoryDependencyInjection
    {
        public static void AddHungryPizzaRepositoryDependencyInjection(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<HungryContext>(options => options.UseNpgsql(configuration.GetConnectionString("PostgreSql")));
            service.AddScoped<IPedidoRepository, PedidoRepository>();
            service.AddScoped<IEnderecoRepository, EnderecoRepository>();
            service.AddScoped<IOpcaoPizzaRepository, OpcaoPizzaRepository>();
            service.AddScoped<IPedidoOpcaoPizzaRepository, PedidoOpcaoPizzaRepository>();
        }
    }
}
