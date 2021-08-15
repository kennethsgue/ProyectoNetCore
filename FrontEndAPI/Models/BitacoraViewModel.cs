using System;
using System.ComponentModel.DataAnnotations;

namespace FrontEndAPI.Models
{
    public class BitacoraViewModel
    {
        [Required]
        public int UsuarioId { get; set; }

        public DateTime? Fecha { get; set; }
        public string Error { get; set; }
    }
}