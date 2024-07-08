using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Enum;

namespace HungryPizza.Domain.Interfaces.Services
{
    public interface IPedidoService
    {
        Task<bool> AtualizaPedidoAsync(string codigoPedido, EStatusPedido novoStatus);
        Task<Pedido> BuscarInformacoesPedidoAsync(string codigoPedido);
        Task<string> RegistrarNovoPedidoAsync(Pedido novoPedido);
    }
}
