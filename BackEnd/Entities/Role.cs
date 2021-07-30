using System;
using System.Collections.Generic;

#nullable disable

namespace BackEnd.Entities
{
    public partial class Role
    {
        public Role()
        {
            Empresas = new HashSet<Empresa>();
            Usuarios = new HashSet<Usuario>();
        }

        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Empresa> Empresas { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
