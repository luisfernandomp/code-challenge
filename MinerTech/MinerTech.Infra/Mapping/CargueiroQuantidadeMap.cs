using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinerTech.Domain;
using MinerTech.Domain.Entities.Cargueiros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Infra.Mapping
{
    public class CargueiroQuantidadeMap : IEntityTypeConfiguration<CargueiroQuantidade>
    {
        public void Configure(EntityTypeBuilder<CargueiroQuantidade> builder)
        {
            builder.ToTable("CargueiroQuantidade");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Quantidade)
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(prop => prop.Cargueiro)
                .WithOne(prop => prop.CargueiroQuantidade)
                .HasForeignKey<CargueiroQuantidade>(prop => prop.CargueiroId);
        }
    }
}
