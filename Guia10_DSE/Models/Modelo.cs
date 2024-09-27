using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Guia10_DSE.Models
{
    public class Modelo
    {
        [Key]
        public int Id { get; set; }
        public string NombreModelo { get; set; }

        [ForeignKey("MarcaID")]
        public int MarcaID { get; set; }
        public Marca Marca { get; set; }
    }
}
