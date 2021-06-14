using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reciclaap.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Local> Local { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<DaPuntos> DaPuntos { get; set; }
        public DbSet<Canje> Canje { get; set; }

    }
}
