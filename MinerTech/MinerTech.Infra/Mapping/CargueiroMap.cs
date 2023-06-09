using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinerTech.Domain.Entities.Cargueiros;


namespace MinerTech.Infra.Mapping
{
    public class CargueiroMap : IEntityTypeConfiguration<Cargueiro>
    {
        public void Configure(EntityTypeBuilder<Cargueiro> builder)
        {
            builder.ToTable("Cargueiro");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.CapacidadeOcupada)
                   .IsRequired()
                   .HasColumnType("decimal(18,4)")
                   .HasPrecision(2);

            builder.HasOne(prop => prop.Classe)
                .WithMany(prop => prop.Cargueiros)
                .HasForeignKey(prop => prop.ClasseId);

            builder.HasOne(prop => prop.CargueiroQuantidade)
                .WithOne(prop => prop.Cargueiro)
                .HasForeignKey<CargueiroQuantidade>(prop => prop.CargueiroId);

            builder.HasOne(prop => prop.Minerio)
                .WithMany(prop => prop.Cargueiros)
                .HasForeignKey(prop => prop.MinerioId);
        }
    }
}
