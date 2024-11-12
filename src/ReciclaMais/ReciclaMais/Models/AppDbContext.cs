using Microsoft.EntityFrameworkCore;
using ReciclaMais.Enuns;

namespace ReciclaMais.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Municipe> Municipes { get; set; }
        public DbSet<OrgaoPublico> OrgaosPublicos { get; set; }
        public DbSet<Noticia> Noticias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<ItemColeta> ItensColeta { get; set; }
        public DbSet<Beneficio> Beneficios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações adicionais do relacionamento entre as entidades, se necessário
            modelBuilder.Entity<Usuario>()
                .HasDiscriminator<TiposUsuario>("TipoUsuario")
                .HasValue<Administrador>(TiposUsuario.Administrador)
                .HasValue<Municipe>(TiposUsuario.Municipe)
                .HasValue<OrgaoPublico>(TiposUsuario.OrgaoPublico);

            base.OnModelCreating(modelBuilder);
        }

    }
}
