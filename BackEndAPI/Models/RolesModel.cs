using System.ComponentModel.DataAnnotations;

namespace BackEndAPI.Models
{
    public class RolesModel
    {
        [Key]
        public int Codigo { get; set; }

        [Required]
        public string Descripcion { get; set; }
    }
}