using HungryPizza.Api.Models.Pedido;

namespace HungryPizza.Api.ViewModels.Pedido
{
    public class RegistrarPedidoRequestModel
    {
        public string Observacao { get; set; }
        public List<List<int>> Sabores { get; set; }
        public EnderecoPedidoModel Endereco { get; set; }
    }
}
