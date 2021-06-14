using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reciclaap.Models
{
    public class Local
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required]
        public string CuilCuit { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public string Horarios { get; set; }

        [Required]
        public string Rubro { get; set; }

        [Required]
        public Boolean Estado { get; set; }

        [Required]
        public string Foto { get; set; }
    }

}
