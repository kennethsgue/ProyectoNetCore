using System.ComponentModel.DataAnnotations;

namespace BackEndAPI.Models
{
    public class AplicacionesModel
    {
        [Required]
        public int UsuarioId { get; set; }

        public int EmpleoId { get; set; }
    }
}