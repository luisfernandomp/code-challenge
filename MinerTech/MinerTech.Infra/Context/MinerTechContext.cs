using Microsoft.EntityFrameworkCore;
using MinerTech.Domain;
using MinerTech.Infra.Mapping;

namespace MinerTech.Infra.Context
{
    public class MinerTechContext : DbContext
    {
        public MinerTechContext (DbContextOptions<MinerTechContext> options) : base(options) 
        {
        }

        public DbSet<Cargueiro> Cargueiros { get; set; }
        public DbSet<CargueiroQuantidade> CargueirosQuantidade { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Minerio> Minerios { get; set; }
        public DbSet<ClasseMinerioCompativel> ClasseMineriosCompativeis { get; set; }
        public DbSet<RetornoCargueiro> CargueirosMinerios { get; set; }
        public DbSet<RetornoHistorico> RetornosHistorico { get; set; }
        public DbSet<Retorno> Retornos { get; set;}
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);
        }
    }
}
