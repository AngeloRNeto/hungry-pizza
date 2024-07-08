using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HungryPizza.Domain.Entities
{
    [Table("opcao_pizza", Schema = "public")]
    public class OpcaoPizza
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("descricao_sabor")]
        public string DescricaoSabor { get; set; }

        [Column("valor")]
        public double Valor { get; set; }
    }
}
