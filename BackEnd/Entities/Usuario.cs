using System;
using System.Collections.Generic;

#nullable disable

namespace BackEnd.Entities
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int? Codigo { get; set; }
        public string Clave { get; set; }
        public byte[] Cv { get; set; }

        public virtual Bitacora Bitacora { get; set; }
    }
}
