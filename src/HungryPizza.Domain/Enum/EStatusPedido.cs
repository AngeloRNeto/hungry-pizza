using System.ComponentModel;

namespace HungryPizza.Domain.Enum
{
    public enum EStatusPedido
    {
        [Description("Pedido Registrado")]
        Registrado = 1,
        [Description("Em andamento de preparo")]
        EmAndamentoDePreparo = 2,
        [Description("Saiu para a entrega")]
        SaiuParaEntrega = 3
    }
}
