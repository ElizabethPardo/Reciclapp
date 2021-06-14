using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reciclaap.Models
{
    public class Producto
    {

        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required]
        public int Codigo { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public double Precio { get; set; }

        [Required]
        public double Descuento { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public int Puntos { get; set; }

        [Required]
        public string Foto { get; set; }

        [Required]
        public Boolean Estado { get; set; }

        [Display(Name = "EcoLocal")]
        public int LocalId { get; set; }
        [ForeignKey("LocalId")]
        public Local EcoLocal { get; set; }
    }
}
