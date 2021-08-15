using System.ComponentModel.DataAnnotations;

namespace FrontEndAPI.Models
{
    public class AplicacionViewModel
    {
        [Required]
        public int UsuarioId { get; set; }

        public int EmpleoId { get; set; }
    }
}