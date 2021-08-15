using System.ComponentModel.DataAnnotations;

namespace BackEndAPI.Models
{
    public class FiltrosModel
    {
        [Key]
        public string Especializacion { get; set; }

        [Required]
        public string Cedula { get; set; }

        public string Nombre { get; set; }
    }
}