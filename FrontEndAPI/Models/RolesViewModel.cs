using System.ComponentModel.DataAnnotations;

namespace FrontEndAPI.Models
{
    public class RolesViewModel
    {
        [Required]
        public int Codigo { get; set; }

        public string Descripcion { get; set; }
    }
}