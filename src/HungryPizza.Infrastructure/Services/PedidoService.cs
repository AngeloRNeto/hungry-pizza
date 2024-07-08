using EnumsNET;
using HungryPizza.Domain;
using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Enum;
using HungryPizza.Domain.Interfaces.Repositories;
using HungryPizza.Domain.Interfaces.Services;

namespace HungryPizza.Infrastructure.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IOpcaoPizzaRepository _opcaoPizzaRepository;
        private readonly IPedidoOpcaoPizzaRepository _pedidoOpcaoPizzaRepository;
        public PedidoService(
            IPedidoRepository pedidoRepository,
            IEnderecoRepository enderecoRepository,
            IOpcaoPizzaRepository opcaoPizzaRepository,
            IPedidoOpcaoPizzaRepository pedidoOpcaoPizzaRepository)
        {
            _pedidoRepository = pedidoRepository;
            _enderecoRepository = enderecoRepository;
            _opcaoPizzaRepository = opcaoPizzaRepository;
            _pedidoOpcaoPizzaRepository = pedidoOpcaoPizzaRepository;
        }

        public async Task<bool> AtualizaPedidoAsync(string codigoPedido, EStatusPedido novoStatus)
        {
            return await _pedidoRepository.AtualizaPedidoAsync(codigoPedido, novoStatus);
        }

        public async Task<Pedido> BuscarInformacoesPedidoAsync(string codigoPedido)
        {
            var pedido = await _pedidoRepository.BuscarInformacoesPedidoAsync(codigoPedido);
            return pedido;
        }

        public async Task<string> RegistrarNovoPedidoAsync(Pedido novoPedido)
        {
            double valor = 0;
            List<PedidoOpcaoPizza> lstPedidoOpcaoPizzas = new List<PedidoOpcaoPizza>();
            var codigo = Utils.GerarCodigoAleatorio(8);
            var lstOpcoesPizzas = await _opcaoPizzaRepository.ListarOpcoesPizzaAsync();

            novoPedido.IdsSabores.ForEach(saboresPedido =>
            {
                valor += lstOpcoesPizzas.Where(opcaoPizza => saboresPedido.Contains(opcaoPizza.Id)).Select(e => e.Valor).Sum() / saboresPedido.Count;

                var pedidoOpcao = saboresPedido.Count() == 2 ?
                new PedidoOpcaoPizza() { IdOpcaoPizza = saboresPedido[0], IdOpcaoPizza2 = saboresPedido[1] } :
                new PedidoOpcaoPizza() { IdOpcaoPizza = saboresPedido[0] };
                lstPedidoOpcaoPizzas.Add(pedidoOpcao);
            });

            novoPedido.Codigo = codigo;
            novoPedido.StatusPedido = EStatusPedido.Registrado;
            novoPedido.Valor = valor;


            if (await _enderecoRepository.SalvarEnderecoAsync(novoPedido.Endereco) > 0)
            {
                novoPedido.EnderecoId = novoPedido.Endereco.Id;

                if (await _pedidoRepository.SalvarPedidoAsync(novoPedido) > 0)
                    lstPedidoOpcaoPizzas.ForEach(e => e.IdPedido = novoPedido.Id);

                if (await _pedidoOpcaoPizzaRepository.SalvarPedidoOpcaoPizzaBatchAsync(lstPedidoOpcaoPizzas) > 0)
                    return codigo;

            }

            return string.Empty;
        }
    }
}
