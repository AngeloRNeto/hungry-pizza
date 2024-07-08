using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Interfaces.Repositories;
using HungryPizza.Domain.Interfaces.Services;

namespace HungryPizza.Infrastructure.Services
{
    public class OpcaoPizzaService : IOpcaoPizzaService
    {
        private readonly IOpcaoPizzaRepository _opcaoPizzaRepository;
        public OpcaoPizzaService(IOpcaoPizzaRepository opcaoPizzaRepository)
        {
            _opcaoPizzaRepository = opcaoPizzaRepository;
        }

        public async Task<List<OpcaoPizza>> ListarOpcoesPizzaAsync()
        {
            return await _opcaoPizzaRepository.ListarOpcoesPizzaAsync();
        }

        public async Task<bool> RegistrarNovaOpcaoPizzaAsync(OpcaoPizza novaOpcaoPizza)
        {
            return await _opcaoPizzaRepository.RegistrarNovaOpcaoPizzaAsync(novaOpcaoPizza);
        }
    }
}
