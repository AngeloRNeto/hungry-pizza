using HungryPizza.Domain.Enum;

namespace HungryPizza.Api.Models.Pedido
{
    public class InformacaoPedidoResponseModel
    {
        public string Codigo { get; set; }
        public double Valor { get; set; }
        public string Observacao { get; set; }
        public string StatusPedido { get; set; }
        public EnderecoPedidoModel Endereco { get; set; }
    }
}
