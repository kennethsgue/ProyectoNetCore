using System.ComponentModel.DataAnnotations;

namespace FrontEndAPI.Models
{
    public class EmpleoViewModel
    {
        [Key]
        public int EmpleoID { get; set; }

        public string NombreEmpleo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Salario { get; set; }
        public string Ubicacion { get; set; }
        public int? EmpresaId { get; set; }
        public string Especializacion { get; set; }
    }
}