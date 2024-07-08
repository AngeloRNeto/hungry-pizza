using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Enum;
using HungryPizza.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HungryPizza.Data.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly HungryContext _context;
        public PedidoRepository(HungryContext context)
        {
            _context = context;
        }

        public async Task<bool> AtualizaPedidoAsync(string codigoPedido, EStatusPedido novoStatus)
        {
            var result = await _context.Pedidos.SingleOrDefaultAsync(ped => ped.Codigo == codigoPedido);
            if (result != null)
            {
                result.StatusPedido = novoStatus;
                return await _context.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<Pedido?> BuscarInformacoesPedidoAsync(string codigoPedido)
        {
            var pedido = await _context.Pedidos
                 .AsNoTracking()
                 .Include(e => e.Endereco)
                 .SingleOrDefaultAsync(ped => ped.Codigo == codigoPedido);

            return pedido is null ? null : pedido;
        }

        public async Task<int> SalvarPedidoAsync(Pedido novoPedido)
        {
            _context.Pedidos.Add(novoPedido);
            return await _context.SaveChangesAsync();
        }
    }
}
