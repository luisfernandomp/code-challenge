using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinerTech.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Infra.Mapping
{
    public class CargueiroMinerioMap : IEntityTypeConfiguration<CargueiroMinerio>
    {
        public void Configure(EntityTypeBuilder<CargueiroMinerio> builder)
        {
            builder.ToTable("CargueiroMinerio");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Cargueiro)
                .WithMany(prop => prop.CargueirosMinerios)
                .HasForeignKey(prop => prop.CargueiroId);

            builder.HasOne(prop => prop.Minerio)
                .WithMany(prop => prop.CargueirosMinerios)
                .HasForeignKey(prop => prop.MinerioId);

        }
    }
}
