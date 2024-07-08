using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryPizza.Data.Repositories
{
    public class PedidoOpcaoPizzaRepository : IPedidoOpcaoPizzaRepository
    {
        private readonly HungryContext _context;
        public PedidoOpcaoPizzaRepository(HungryContext context)
        {
            _context = context;
        }

        public async Task<int> SalvarPedidoOpcaoPizzaBatchAsync(List<PedidoOpcaoPizza> lstPedidoOpcaoPizzas)
        {
            await _context.PedidoOpcaoPizzas.AddRangeAsync(lstPedidoOpcaoPizzas);
            return await _context.SaveChangesAsync();
        }
    }
}
