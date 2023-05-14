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
    public class RetornoMap : IEntityTypeConfiguration<Retorno>
    {
        public void Configure(EntityTypeBuilder<Retorno> builder)
        {
            builder.ToTable("Retorno");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.DataSaida)
                    .HasColumnType("datetime")
                    .IsRequired();

            builder.Property(prop => prop.DataRetorno)
                    .HasColumnType("datetime");

            builder.Property(prop => prop.DataCadastro)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(prop => prop.Total)
               .IsRequired()
               .HasColumnType("float")
               .HasPrecision(2);

            builder.HasOne(prop => prop.Usuario)
                .WithMany(prop => prop.Retornos)
                .HasForeignKey(prop => prop.UsuarioId);
        }
    }
}
