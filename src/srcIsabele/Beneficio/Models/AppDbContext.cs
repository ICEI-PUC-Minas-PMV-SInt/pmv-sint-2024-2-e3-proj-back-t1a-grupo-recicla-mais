using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Application.Models;
using Beneficio.Models;

namespace Application.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BeneficioModel> Beneficio { get; set; } = default!;
    }
}