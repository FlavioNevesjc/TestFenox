using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestFenox.Models
{
    [Table("Fuel")]
    public class Fuel
    {
        [Key]
        public int IdFuel { get; set; }

        [DisplayName("Descrição do combustivel")]
        [Required]
        public string DescriptionFuel { get; set; }

        [DisplayName("Status")]
        public int StatusFuel { get; set; }
    }
}
