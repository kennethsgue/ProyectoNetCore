#nullable disable

namespace BackEnd.Entities
{
    public partial class Aplicacione
    {
        public int UsuarioId { get; set; }
        public int EmpleoId { get; set; }

        public virtual Empleo Empleo { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}