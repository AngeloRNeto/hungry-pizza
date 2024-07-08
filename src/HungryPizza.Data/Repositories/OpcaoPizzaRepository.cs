using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HungryPizza.Data.Repositories
{
    public class OpcaoPizzaRepository : IOpcaoPizzaRepository
    {
        private readonly HungryContext _context;
        public OpcaoPizzaRepository(HungryContext context)
        {
            _context = context;
        }

        public async Task<List<OpcaoPizza>> ListarOpcoesPizzaAsync()
        {
            return await _context.OpcaoPizzas.AsNoTracking().ToListAsync();
        }

        public async Task<bool> RegistrarNovaOpcaoPizzaAsync(OpcaoPizza novaOpcaoPizza)
        {
            _context.OpcaoPizzas.Add(novaOpcaoPizza);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
