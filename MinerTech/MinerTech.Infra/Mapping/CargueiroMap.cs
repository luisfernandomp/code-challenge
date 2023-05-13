using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinerTech.Domain;
using MinerTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Infra.Mapping
{
    public class CargueiroMap : IEntityTypeConfiguration<Cargueiro>
    {
        public void Configure(EntityTypeBuilder<Cargueiro> builder)
        {
            builder.ToTable("Cargueiro");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Capacidade)
                   .IsRequired()
                   .HasColumnType("float");

            builder.HasOne(prop => prop.Classe)
                .WithMany(prop => prop.Cargueiros)
                .HasForeignKey(prop => prop.ClasseId);

            builder.HasOne(prop => prop.CargueiroQuantidade)
                .WithOne(prop => prop.Cargueiro)
                .HasForeignKey<CargueiroQuantidade>(prop => prop.CargueiroId);

        }
    }
}
