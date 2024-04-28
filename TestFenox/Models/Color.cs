using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestFenox.Models
{
    [Table("Color")]
    public class Color
    {
        [Key]
        public int IdColor { get; set; }

        [DisplayName("Descrição da Cor")]
        [Required]
        public string DescriptionColor { get; set; }

        [DisplayName("Status")]
        public int StatusColor { get; set; }
    }
}
