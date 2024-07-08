using HungryPizza.Api.Models.OpcaoPizza;

namespace HungryPizza.Api.AppService.Interfaces
{
    public interface IOpcaoPizzaAppService
    {
        Task<List<RegistroOpcaoPizzaModel>> ListarOpcoesPizzaAsync();
        Task<bool> RegistrarNovaOpcaoPizzaAsync(RegistroOpcaoPizzaModel registrarOpcaoPizza);
    }
}
