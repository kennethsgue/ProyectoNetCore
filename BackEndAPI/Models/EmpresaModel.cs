using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndAPI.Models
{
    public class EmpresaModel
    {
        [Key]
        public int EmpresaID { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Clave { get; set; }
        public string Correo { get; set; }
        public string CedulaJuridica { get; set; }
        public int? Codigo { get; set; }
    }
}
