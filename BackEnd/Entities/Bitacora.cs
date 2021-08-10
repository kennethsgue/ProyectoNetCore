using System;
using System.Collections.Generic;

#nullable disable

namespace BackEnd.Entities
{
    public partial class Bitacora
    {
        public int UsuarioId { get; set; }
        public DateTime? Fecha { get; set; }
        public string Error { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
