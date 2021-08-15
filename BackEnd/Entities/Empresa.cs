using System.Collections.Generic;

#nullable disable

namespace BackEnd.Entities
{
    public partial class Empresa
    {
        public Empresa()
        {
            Empleos = new HashSet<Empleo>();
        }

        public int EmpresaId { get; set; }
        public string Descripcion { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Clave { get; set; }
        public string Correo { get; set; }
        public string CedulaJuridica { get; set; }
        public int? Codigo { get; set; }

        public virtual Role CodigoNavigation { get; set; }
        public virtual ICollection<Empleo> Empleos { get; set; }
    }
}