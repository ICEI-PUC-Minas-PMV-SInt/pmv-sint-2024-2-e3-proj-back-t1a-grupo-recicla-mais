using Microsoft.EntityFrameworkCore;

namespace ReciclaMais.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Noticia> Noticias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Beneficio> Beneficios { get; set; }

    }
}
