using HungryPizza.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HungryPizza.Domain.Entities
{
    [Table("pedido", Schema = "public")]
    public class Pedido
    {
        public Pedido()
        {
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("codigo")]
        public string Codigo { get; set; }

        [Column("status_pedido_id")]
        public EStatusPedido StatusPedido { get; set; }

        [Column("valor")]
        public double Valor { get; set; }

        [Column("observacao")]
        public string Observacao { get; set; }

        [Column("endereco_id")]
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }

        [NotMapped]
        public List<List<int>> IdsSabores { get; set; }
    }
}
