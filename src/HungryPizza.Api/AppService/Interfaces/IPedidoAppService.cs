using HungryPizza.Api.Models.Pedido;
using HungryPizza.Api.ViewModels.Pedido;
using HungryPizza.Domain.Enum;

namespace HungryPizza.Api.AppService.Interfaces
{
    public interface IPedidoAppService
    {
        Task<bool> AtualizaPedidoAsync(string codigoPedido, EStatusPedido novoStatus);
        Task<InformacaoPedidoResponseModel?> BuscarInformacoesPedidoAsync(string codigoPedido);
        Task<RegistrarPedidoResponseModel> RegistrarNovoPedidoAsync(RegistrarPedidoRequestModel registrarPedido);
    }
}
