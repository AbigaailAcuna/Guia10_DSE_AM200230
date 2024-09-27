using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace Guia10_DSE.Models
{
    public class Marca
    {
        [Key]
        public int Id { get; set; } 
        public string NombreMarca { get; set; } 

    
    }
}
