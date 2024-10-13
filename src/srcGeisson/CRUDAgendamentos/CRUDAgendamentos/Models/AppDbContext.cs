using Microsoft.EntityFrameworkCore;

namespace CRUDAgendamentos.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Agendamento> Agendamentos { get; set; }
    }
}
