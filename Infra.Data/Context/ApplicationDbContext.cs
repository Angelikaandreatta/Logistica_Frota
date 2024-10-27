using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Endereco_Entrega> Enderecos_Entregas { get; set; }
        public DbSet<Entrega> Entregas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}