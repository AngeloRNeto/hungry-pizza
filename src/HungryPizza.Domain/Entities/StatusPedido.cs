using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HungryPizza.Domain.Entities
{
    [Table("status_pedido", Schema = "public")]
    public class StatusPedido
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }
    }
}
