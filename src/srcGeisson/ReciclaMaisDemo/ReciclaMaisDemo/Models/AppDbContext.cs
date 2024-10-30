using Microsoft.EntityFrameworkCore;

namespace ReciclaMaisDemo.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        // DbSets.
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
