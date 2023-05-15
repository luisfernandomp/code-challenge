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
    public class ClasseMap : IEntityTypeConfiguration<Classe>
    {
        public void Configure(EntityTypeBuilder<Classe> builder)
        {
            builder.ToTable("Classe");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Descricao)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(prop => prop.DataCadastro)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(prop => prop.Capacidade)
                   .IsRequired()
                   .HasColumnType("float")
                   .HasPrecision(2);

            builder.Property(prop => prop.Ativo)
                .HasColumnType("bit")
                .IsRequired();

            builder.HasMany(prop => prop.Cargueiros)
                .WithOne(prop => prop.Classe)
                .HasForeignKey(prop => prop.ClasseId);


            builder.HasData(new {
                Capacidade = 5,
                Descricao = "I",
                DataCadastro = DateTime.Now,
                Ativo = true
            });

            builder.HasData(new
            {
                Capacidade = 3,
                Descricao = "II",
                DataCadastro = DateTime.Now,
                Ativo = true
            });

            builder.HasData(new
            {
                Capacidade = 2,
                Descricao = "III",
                DataCadastro = DateTime.Now,
                Ativo = true
            });

            builder.HasData(new
            {
                Capacidade = 0.5M,
                Descricao = "IV",
                DataCadastro = DateTime.Now,
                Ativo = true
            });
        }
    }
}
