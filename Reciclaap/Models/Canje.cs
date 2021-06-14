using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reciclaap.Models
{
    public class Canje
    {
        [Key]
		[Display(Name = "Código")]
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public int Cant { get; set; }

        [Required]
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario User { get; set; }

        [Display(Name = "Producto")]
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Producto Producto { get; set; }

      


    }
}
