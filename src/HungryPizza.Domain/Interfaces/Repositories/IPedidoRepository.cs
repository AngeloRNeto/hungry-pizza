using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Enum;

namespace HungryPizza.Domain.Interfaces.Repositories
{
    public interface IPedidoRepository
    {
        Task<bool> AtualizaPedidoAsync(string codigoPedido, EStatusPedido novoStatus);
        Task<Pedido?> BuscarInformacoesPedidoAsync(string codigoPedido);
        Task<int> SalvarPedidoAsync(Pedido novoPedido);
    }
}
