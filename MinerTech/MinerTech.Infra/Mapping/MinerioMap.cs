using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinerTech.Domain;
using MinerTech.Domain.Entities.Minerios;

namespace MinerTech.Infra.Mapping
{
    public class MinerioMap : IEntityTypeConfiguration<Minerio>
    {
        public void Configure(EntityTypeBuilder<Minerio> builder)
        {
            builder.ToTable("Minerio");

            builder.HasKey(prop => prop.Id);
            
            builder.Property(prop => prop.Codigo)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(prop => prop.Caracteristica)
                .HasColumnType("varchar(400)")
                .IsRequired();

            builder.Property(prop => prop.Preco)
                .HasColumnType("decimal(18,4)")
               .IsRequired()
               .HasPrecision(2);

            builder.Property(prop => prop.Ativo)
                .HasColumnType("bit")
                .IsRequired();

            builder.HasMany(prop => prop.Cargueiros)
                .WithOne(prop => prop.Minerio)
                .HasForeignKey(prop => prop.MinerioId);

            builder.HasData(new
            {
                Codigo = "A",
                Preco = 0M,
                Caracteristica = "Inflamável",
                DataCadastro = DateTime.Now,
                Ativo = true
            });

        }
    }
}
