using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndAPI.Models
{
    public class EmpleoModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EmpleoID { get; set; }

        [Required]
        public string NombreEmpleo { get; set; }

        public string Descripcion { get; set; }
        public decimal? Salario { get; set; }
        public string Ubicacion { get; set; }
        public int? EmpresaId { get; set; }
        public string Especializacion { get; set; }
    }
}