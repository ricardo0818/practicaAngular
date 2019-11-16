using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Model.Entities
{
    public class DetallePago
    {
        [Key]
        public int IdTarjeta { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string NombrePropietario { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(16)")]
        public string NumeroTarjeta { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string FechaExpiracion { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string CVV { get; set; }

    }

}
