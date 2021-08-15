using System.ComponentModel.DataAnnotations;

namespace FrontEndAPI.Models
{
    public class FiltrosViewModel
    {
        [Required]
        public string Especializacion { get; set; }

        public string Cedula { get; set; }
        public string Nombre { get; set; }
    }
}