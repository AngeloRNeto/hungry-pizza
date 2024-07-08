using HungryPizza.Domain.Entities;

namespace HungryPizza.Domain.Interfaces.Repositories
{
    public interface IOpcaoPizzaRepository
    {
        Task<List<OpcaoPizza>> ListarOpcoesPizzaAsync();
        Task<bool> RegistrarNovaOpcaoPizzaAsync(OpcaoPizza novaOpcaoPizza);
    }
}
