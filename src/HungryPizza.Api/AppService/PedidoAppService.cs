using AutoMapper;
using HungryPizza.Api.AppService.Interfaces;
using HungryPizza.Api.Models.Pedido;
using HungryPizza.Api.ViewModels.Pedido;
using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Enum;
using HungryPizza.Domain.Interfaces.Services;

namespace HungryPizza.Api.AppService
{
    public class PedidoAppService : IPedidoAppService
    {
        private readonly IPedidoService _pedidoService;
        private readonly IMapper _mapper;
        public PedidoAppService(IPedidoService pedidoService, IMapper mapper)
        {
            _pedidoService = pedidoService;
            _mapper = mapper;
        }

        public async Task<bool> AtualizaPedidoAsync(string codigoPedido, EStatusPedido novoStatus)
        {
            return await _pedidoService.AtualizaPedidoAsync(codigoPedido, novoStatus);
        }

        public async Task<InformacaoPedidoResponseModel?> BuscarInformacoesPedidoAsync(string codigoPedido)
        {
            var pedido = await _pedidoService.BuscarInformacoesPedidoAsync(codigoPedido);
            return pedido is not null ? _mapper.Map<InformacaoPedidoResponseModel>(pedido) : null;
        }

        public async Task<RegistrarPedidoResponseModel> RegistrarNovoPedidoAsync(RegistrarPedidoRequestModel registrarPedido)
        {
            var novoPedido = _mapper.Map<Pedido>(registrarPedido);
            var codigoPedido = await _pedidoService.RegistrarNovoPedidoAsync(novoPedido);
            return new RegistrarPedidoResponseModel { CodigoPedido = codigoPedido, Mensagem = "Novo pedido realizado com sucesso" };

        }
    }
}
