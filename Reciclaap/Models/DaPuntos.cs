using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reciclaap.Models
{
    public class DaPuntos
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int Puntos { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario User { get; set; }

        [Display(Name = "EcoLocal")]
        public int LocalId { get; set; }
        [ForeignKey("LocalId")]
        public Local EcoLocal { get; set; }

     
    }
}
