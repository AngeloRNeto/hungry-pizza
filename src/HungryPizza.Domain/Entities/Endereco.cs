using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HungryPizza.Domain.Entities
{
    [Table("endereco", Schema = "public")]
    public class Endereco
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("rua")]
        public string Rua { get; set; }

        [Column("numero")]
        public string Numero { get; set; }

        [Column("complemento")]
        public string Complemento { get; set; }

        [Column("bairro")]
        public string Bairro { get; set; }
    }
}
