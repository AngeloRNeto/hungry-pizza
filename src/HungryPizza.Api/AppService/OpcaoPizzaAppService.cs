using AutoMapper;
using HungryPizza.Api.AppService.Interfaces;
using HungryPizza.Api.Models.OpcaoPizza;
using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Interfaces.Services;

namespace HungryPizza.Api.AppService
{
    public class OpcaoPizzaAppService : IOpcaoPizzaAppService
    {
        private readonly IMapper _mapper;
        private readonly IOpcaoPizzaService _opcaoPizzaService;
        public OpcaoPizzaAppService(IMapper mapper, IOpcaoPizzaService opcaoPizzaService)
        {
            _mapper = mapper;
            _opcaoPizzaService = opcaoPizzaService;
        }

        public async Task<List<RegistroOpcaoPizzaModel>> ListarOpcoesPizzaAsync()
        {
            var opcaoPizzas = await _opcaoPizzaService.ListarOpcoesPizzaAsync();
            return _mapper.Map<List<RegistroOpcaoPizzaModel>>(opcaoPizzas);
        }

        public async Task<bool> RegistrarNovaOpcaoPizzaAsync(RegistroOpcaoPizzaModel registrarOpcaoPizza)
        {
            var novaOpcaoPizza = _mapper.Map<OpcaoPizza>(registrarOpcaoPizza);
            return await _opcaoPizzaService.RegistrarNovaOpcaoPizzaAsync(novaOpcaoPizza);
        }
    }
}
