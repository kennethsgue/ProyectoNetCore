using System;
using System.Collections.Generic;

#nullable disable

namespace BackEnd.Entities
{
    public partial class Filtro
    {
        public Filtro()
        {
            Empleos = new HashSet<Empleo>();
        }

        public string Cedula { get; set; }
        public string Especializacion { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Empleo> Empleos { get; set; }
    }
}
