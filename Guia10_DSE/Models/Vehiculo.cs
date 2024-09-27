using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Guia10_DSE.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ModeloID")]
        public int ModeloID { get; set; }
        public Modelo Modelo { get; set; }

        public string FechaFabricacion { get; set; }
    }
}
