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
    public class RetornoHistoricoMap : IEntityTypeConfiguration<RetornoHistorico>
    {
        public void Configure(EntityTypeBuilder<RetornoHistorico> builder)
        {
            builder.ToTable("RetornoHistorico");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.QuantidadeAnterior)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(prop => prop.QuantidadeAtual)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(prop => prop.Quantidade)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(prop => prop.DateCadastro)
                .HasColumnType("datetime")
                .IsRequired();

            builder.HasOne(prop => prop.Retorno)
                .WithMany(prop => prop.RetornosHistorico)
                .HasForeignKey(prop => prop.RetornoId);

            builder.HasOne(prop => prop.Usuario)
                .WithMany(prop => prop.RetornosHistorico)
                .HasForeignKey(prop => prop.UsuarioId);
        }
    }
}
