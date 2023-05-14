using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinerTech.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Infra.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Ativo)
                .IsRequired()
                .HasColumnType("bit");

            builder.Property(prop => prop.DataCadastro)
                .IsRequired();

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(300)");

            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasColumnType("varchar(300)");

            builder.HasMany(prop => prop.Retornos)
                .WithOne(prop => prop.Usuario)
                .HasForeignKey(prop => prop.UsuarioId);

            builder.HasMany(prop => prop.RetornosHistorico)
                .WithOne(prop => prop.Usuario)
                .HasForeignKey(prop => prop.UsuarioId);
        }
    }
}
