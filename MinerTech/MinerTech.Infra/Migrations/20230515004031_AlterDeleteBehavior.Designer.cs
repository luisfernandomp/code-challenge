﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinerTech.Infra.Context;

#nullable disable

namespace MinerTech.Infra.Migrations
{
    [DbContext(typeof(MinerTechContext))]
    [Migration("20230515004031_AlterDeleteBehavior")]
    partial class AlterDeleteBehavior
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MinerTech.Domain.Cargueiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CapacidadeOcupada")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ClasseId")
                        .HasColumnType("int");

                    b.Property<int>("MinerioId")
                        .HasColumnType("int");

                    b.Property<decimal>("PesoMinerio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.HasIndex("MinerioId");

                    b.ToTable("Cargueiros");
                });

            modelBuilder.Entity("MinerTech.Domain.CargueiroQuantidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CargueiroId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CargueiroId")
                        .IsUnique();

                    b.ToTable("CargueirosQuantidade");
                });

            modelBuilder.Entity("MinerTech.Domain.Classe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<decimal>("Capacidade")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("MinerTech.Domain.Minerio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Caracteristica")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Minerios");
                });

            modelBuilder.Entity("MinerTech.Domain.Retorno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataRetorno")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Retornos");
                });

            modelBuilder.Entity("MinerTech.Domain.RetornoCargueiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CargueiroId")
                        .HasColumnType("int");

                    b.Property<int>("MineiroId")
                        .HasColumnType("int");

                    b.Property<int>("MinerioId")
                        .HasColumnType("int");

                    b.Property<int?>("RetornoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CargueiroId");

                    b.HasIndex("MinerioId");

                    b.HasIndex("RetornoId");

                    b.ToTable("CargueirosMinerios");
                });

            modelBuilder.Entity("MinerTech.Domain.RetornoHistorico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CargueiroId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCadastro")
                        .HasColumnType("datetime2");

                    b.Property<int>("MinerioId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeAnterior")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeAtual")
                        .HasColumnType("int");

                    b.Property<int?>("RetornoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CargueiroId");

                    b.HasIndex("MinerioId");

                    b.HasIndex("RetornoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("RetornosHistorico");
                });

            modelBuilder.Entity("MinerTech.Domain.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("MinerTech.Domain.Cargueiro", b =>
                {
                    b.HasOne("MinerTech.Domain.Classe", "Classe")
                        .WithMany("Cargueiros")
                        .HasForeignKey("ClasseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MinerTech.Domain.Minerio", "Minerio")
                        .WithMany("Cargueiros")
                        .HasForeignKey("MinerioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Classe");

                    b.Navigation("Minerio");
                });

            modelBuilder.Entity("MinerTech.Domain.CargueiroQuantidade", b =>
                {
                    b.HasOne("MinerTech.Domain.Cargueiro", "Cargueiro")
                        .WithOne("CargueiroQuantidade")
                        .HasForeignKey("MinerTech.Domain.CargueiroQuantidade", "CargueiroId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cargueiro");
                });

            modelBuilder.Entity("MinerTech.Domain.Retorno", b =>
                {
                    b.HasOne("MinerTech.Domain.Usuario", "Usuario")
                        .WithMany("Retornos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MinerTech.Domain.RetornoCargueiro", b =>
                {
                    b.HasOne("MinerTech.Domain.Cargueiro", "Cargueiro")
                        .WithMany("RetornosCargueiro")
                        .HasForeignKey("CargueiroId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MinerTech.Domain.Minerio", "Minerio")
                        .WithMany("RetornosCargueiro")
                        .HasForeignKey("MinerioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MinerTech.Domain.Retorno", null)
                        .WithMany("RetornosCargueiro")
                        .HasForeignKey("RetornoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Cargueiro");

                    b.Navigation("Minerio");
                });

            modelBuilder.Entity("MinerTech.Domain.RetornoHistorico", b =>
                {
                    b.HasOne("MinerTech.Domain.Cargueiro", "Cargueiro")
                        .WithMany("RetornosHistorico")
                        .HasForeignKey("CargueiroId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MinerTech.Domain.Minerio", "Minerio")
                        .WithMany("RetornosHistorico")
                        .HasForeignKey("MinerioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MinerTech.Domain.Retorno", null)
                        .WithMany("RetornosHistorico")
                        .HasForeignKey("RetornoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MinerTech.Domain.Usuario", "Usuario")
                        .WithMany("RetornosHistorico")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cargueiro");

                    b.Navigation("Minerio");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MinerTech.Domain.Cargueiro", b =>
                {
                    b.Navigation("CargueiroQuantidade")
                        .IsRequired();

                    b.Navigation("RetornosCargueiro");

                    b.Navigation("RetornosHistorico");
                });

            modelBuilder.Entity("MinerTech.Domain.Classe", b =>
                {
                    b.Navigation("Cargueiros");
                });

            modelBuilder.Entity("MinerTech.Domain.Minerio", b =>
                {
                    b.Navigation("Cargueiros");

                    b.Navigation("RetornosCargueiro");

                    b.Navigation("RetornosHistorico");
                });

            modelBuilder.Entity("MinerTech.Domain.Retorno", b =>
                {
                    b.Navigation("RetornosCargueiro");

                    b.Navigation("RetornosHistorico");
                });

            modelBuilder.Entity("MinerTech.Domain.Usuario", b =>
                {
                    b.Navigation("Retornos");

                    b.Navigation("RetornosHistorico");
                });
#pragma warning restore 612, 618
        }
    }
}