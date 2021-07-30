using System;
using System.Collections.Generic;

#nullable disable

namespace BackEnd.Entities
{
    public partial class Empleo
    {
        public int IdEmpleo { get; set; }
        public string NombreEmpleo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Salario { get; set; }
        public string Ubicacion { get; set; }
        public int? IdEmpresa { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
    }
}
