using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinerTech.Domain;


namespace MinerTech.Infra.Mapping
{
    public class ClasseMinerioCompativelMap : IEntityTypeConfiguration<ClasseMinerioCompativel>
    {
        public void Configure(EntityTypeBuilder<ClasseMinerioCompativel> builder)
        {
            builder.ToTable("ClasseMinerioCompativel");
            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Minerio)
                .WithMany(prop => prop.ClasseMineriosCompativeis)
                .HasForeignKey(prop => prop.MinerioId);

            builder.HasOne(prop => prop.Classe)
                .WithMany(prop => prop.ClasseMineriosCompativeis)
                .HasForeignKey(prop => prop.ClasseId);
        }
    }
}
