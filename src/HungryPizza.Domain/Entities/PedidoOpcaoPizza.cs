using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HungryPizza.Domain.Entities
{
    [Table("pedido_opcao_pizza", Schema = "public")]
    public class PedidoOpcaoPizza
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id_pedido")]
        public int IdPedido { get; set; }

        [Column("id_opcao_pizza")]
        public int IdOpcaoPizza { get; set; }

        [Column("id_opcao_pizza_2")]
        public int IdOpcaoPizza2 { get; set; }
    }
}
