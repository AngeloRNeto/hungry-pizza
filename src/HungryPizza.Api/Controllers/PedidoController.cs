using EnumsNET;
using HungryPizza.Api.AppService.Interfaces;
using HungryPizza.Api.Models.Pedido;
using HungryPizza.Api.ViewModels.Pedido;
using HungryPizza.Domain.Enum;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace HungryPizza.Api.Controllers
{
    [ApiController]
    [Route("api/pedido")]
    public class PedidoController : ControllerBase
    {
        private readonly ILogger<PedidoController> _logger;
        private readonly IPedidoAppService _appService;
        public PedidoController(ILogger<PedidoController> logger, IPedidoAppService appService)
        {
            _logger = logger;
            _appService = appService;
        }

        /// <summary>
        /// Busca as informações do pedido através do código gerado no registro
        /// </summary>
        /// <returns>StatusPedidoResponseModel</returns>
        /// <response code="200">Retorna status do pedido</response>
        /// <response code="204">Não foi encontrado nenhum pedido com o código informado</response>
        /// <response code="400">Requisição não esperada</response>
        [HttpGet]
        [Route("buscar-informacao-pedido")]
        public async Task<ActionResult<InformacaoPedidoResponseModel>> BuscarInformacoesPedidoAsync([Required] string codigoPedido)
        {
            _logger.LogInformation($"GET - {nameof(BuscarInformacoesPedidoAsync)}({codigoPedido})");

            var response = await _appService.BuscarInformacoesPedidoAsync(codigoPedido);

            if (response is null)
                return NoContent();

            return Ok(response);

        }

        /// <summary>
        /// Registra um novo pedido
        /// </summary>
        /// <returns>Status Pedido</returns>
        /// <response code="200">Retorna status do pedido</response>
        [HttpPost]
        [Route("novo-pedido")]
        public async Task<ActionResult<RegistrarPedidoResponseModel>> RegistrarNovoPedidoAsync(RegistrarPedidoRequestModel registroPedido)
        {
            _logger.LogInformation($"POST - {nameof(RegistrarNovoPedidoAsync)}({JsonSerializer.Serialize(registroPedido)})");

            var response = await _appService.RegistrarNovoPedidoAsync(registroPedido);

            return Ok(response);
        }


        /// <summary>
        /// Atualiza o status do pedido pelo código
        /// </summary>
        /// <returns>Status Pedido</returns>
        /// <response code="200">Retorna o valor de sucesso ou não da atualização</response>
        /// <response code="400">Requisição não esperada</response>

        [HttpPatch]
        [Route("atualiza-status-pedido")]
        public async Task<ActionResult<bool>> AtualizaPedidoAsync([Required] string codigoPedido, [Required] EStatusPedido novoStatus)
        {
            _logger.LogInformation($"PATCH - {nameof(AtualizaPedidoAsync)}({codigoPedido}, {novoStatus.AsString(EnumFormat.Description)})");

            bool response = await _appService.AtualizaPedidoAsync(codigoPedido, novoStatus);

            return Ok(response);
        }
    }
}
