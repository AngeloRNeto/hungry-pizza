using HungryPizza.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryPizza.Domain.Interfaces.Repositories
{
    public interface IPedidoOpcaoPizzaRepository
    {
        Task<int> SalvarPedidoOpcaoPizzaBatchAsync(List<PedidoOpcaoPizza> lstPedidoOpcaoPizzas);
    }
}
