using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinerTech.Domain;

namespace MinerTech.Infra.Mapping
{
    public class RetornoCargueiroMap : IEntityTypeConfiguration<RetornoCargueiro>
    {
        public void Configure(EntityTypeBuilder<RetornoCargueiro> builder)
        {
            builder.ToTable("RetornoCargueiro");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Minerio)
                .WithMany(prop => prop.RetornosCargueiro)
                .HasForeignKey(prop => prop.MineiroId);

            builder.HasOne(prop => prop.Cargueiro)
                .WithMany(prop => prop.RetornosCargueiro)
                .HasForeignKey(prop => prop.CargueiroId);
        }
    }
}
