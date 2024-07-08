using HungryPizza.Api.AppService.Interfaces;
using HungryPizza.Api.Models.OpcaoPizza;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace HungryPizza.Api.Controllers
{
    [ApiController]
    [Route("api/opcao-pizza")]
    public class OpcaoPizzaController : ControllerBase
    {
        private readonly ILogger<OpcaoPizzaController> _logger;
        private readonly IOpcaoPizzaAppService _appService;
        public OpcaoPizzaController(ILogger<OpcaoPizzaController> logger, IOpcaoPizzaAppService appService)
        {
            _logger = logger;
            _appService = appService;
        }

        /// <summary>
        /// Registra nova opção de sabor de uma pizza
        /// </summary>
        /// <returns>Status Pedido</returns>
        /// <response code="200">Registro de novo sabor efetuado com sucesso</response>
        /// <response code="422">Não foi possivel efetuar o novo registro</response>
        [HttpPost]
        [Route("registrar-nova-opcao")]
        public async Task<ActionResult> RegistrarNovaOpcaoPizzaAsync(RegistroOpcaoPizzaModel registrarOpcaoPizza)
        {
            _logger.LogInformation($"POST - {nameof(RegistrarNovaOpcaoPizzaAsync)}({JsonSerializer.Serialize(registrarOpcaoPizza)})");

            bool result = await _appService.RegistrarNovaOpcaoPizzaAsync(registrarOpcaoPizza);

            if (result)
                return Ok();

            return UnprocessableEntity();
        }

        /// <summary>
        /// Retorna as opções de sabores salvas da pizzaria
        /// </summary>
        /// <returns>Status Pedido</returns>
        /// <response code="200">Lista de OpcoesPizza</response>
        /// <response code="204">Nenhum registro encontrado</response>
        [HttpGet]
        [Route("listar-opcao-pizza")]
        public async Task<ActionResult<List<RegistroOpcaoPizzaModel>>> ListarOpcoesPizzaAsync()
        {
            _logger.LogInformation($"GET - {nameof(ListarOpcoesPizzaAsync)}");

            List<RegistroOpcaoPizzaModel> result = await _appService.ListarOpcoesPizzaAsync();

            if (result.Any())
                return Ok(result.OrderBy(e => e.DescricaoSabor));

            return NoContent();
        }
    }
}
