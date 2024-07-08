using HungryPizza.Domain.Entities;

namespace HungryPizza.Domain.Interfaces.Services
{
    public interface IOpcaoPizzaService
    {
        Task<List<OpcaoPizza>> ListarOpcoesPizzaAsync();
        Task<bool> RegistrarNovaOpcaoPizzaAsync(OpcaoPizza novaOpcaoPizza);
    }
}
