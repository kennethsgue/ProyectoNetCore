using System;
using System.Collections.Generic;

#nullable disable

namespace BackEnd.Entities
{
    public partial class Empleo
    {
        public int EmpleoId { get; set; }
        public string NombreEmpleo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Salario { get; set; }
        public string Ubicacion { get; set; }
        public int? EmpresaId { get; set; }
        public string Especializacion { get; set; }


        public virtual Empresa Empresa { get; set; }
        public virtual Filtro EspecializacionNavigation { get; set; }
    }
}
