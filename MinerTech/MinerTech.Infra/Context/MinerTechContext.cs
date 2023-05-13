using Microsoft.EntityFrameworkCore;
using MinerTech.Domain;
using MinerTech.Infra.Mapping;

namespace MinerTech.Infra.Context
{
    public class MinerTechContext : DbContext
    {
        public MinerTechContext (DbContextOptions<DbContext> options) : base(options) 
        {
        }

        public DbSet<Cargueiro> Cargueiros { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<CargueiroQuantidade> CargueirosQuantidade { get; set; }
        public DbSet<Minerio> Minerios { get; set; }
        public DbSet<CargueiroMinerio> CargueirosMinerios { get; set; }
        public DbSet<Retorno> Retornos { get; set;}
        public DbSet<RetornoHistorico> RetornosHistorico { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CargueiroMap());
            modelBuilder.ApplyConfiguration(new ClasseMap());
            modelBuilder.ApplyConfiguration(new CargueiroQuantidadeMap());
            modelBuilder.ApplyConfiguration(new MinerioMap());
            modelBuilder.ApplyConfiguration(new CargueiroMinerioMap());
            modelBuilder.ApplyConfiguration(new RetornoMap());
            modelBuilder.ApplyConfiguration(new RetornoHistoricoMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
