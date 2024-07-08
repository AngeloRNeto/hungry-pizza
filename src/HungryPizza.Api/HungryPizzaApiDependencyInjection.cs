using HungryPizza.Api.AppService;
using HungryPizza.Api.AppService.Interfaces;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace HungryPizza.Api
{
    public static class HungryPizzaApiDependencyInjection
    {
        public static void AddHungryPizzaApiDependencyInjection(this IServiceCollection service)
        {
            AddSwaggerConfig(service);
            service.AddScoped<IPedidoAppService, PedidoAppService>();
            service.AddScoped<IOpcaoPizzaAppService, OpcaoPizzaAppService>();
        }

        private static void AddSwaggerConfig(IServiceCollection service)
        {
            service.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "API Hungry Pizza",
                    Description = "Aplicação para gerenciamento de pedidos da pizzaria.",
                    Contact = new OpenApiContact() { Name = "Angelo Rocha Neto", Email = "work.angelorocha@gmail.com" }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            }
    );
        }
    }
}
