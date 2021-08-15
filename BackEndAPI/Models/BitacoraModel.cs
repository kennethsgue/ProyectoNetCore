using System;
using System.ComponentModel.DataAnnotations;

namespace BackEndAPI.Models
{
    public class BitacoraModel
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required]
        public DateTime? Fecha { get; set; }

        public string Error { get; set; }
    }
}