using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestFenox.Models
{
    [Table("Vehicle")]
    public class Vehicle
    {
        [Key]
        public int IdVehicle { get; set; }
        
        [DisplayName("Placa")]
        [Required]
        public string Plate { get; set; }
        
        [DisplayName("Renavan")]
        [Required]
        public string Renavan { get; set; }

        [DisplayName("Numero do Chassi")]
        [Required]
        public string ChassisNumber { get; set; }

        [DisplayName("Numero do Motor")]
        [Required]
        public string EngineNumber { get; set; }

        [DisplayName("Marca do Veiculo")]
        [Required]
        public string Brand { get; set; }
        
        [DisplayName("Modelo do Veiculo")]
        [Required]
        public string Model {  get; set; }

        [DisplayName("Combustivel")]
        [Required]
        public Fuel FuelId_F { get; set; }

        [DisplayName("Cor")]
        [Required]
        public Color ColorId_F { get; set; }

        [DisplayName("Ano de Fabricação")]
        [Required]
        public string YearOfManufacture {  get; set; }

        [DisplayName("Status")]
        public int StatusVehicle { get; set; }
        
    }
}
