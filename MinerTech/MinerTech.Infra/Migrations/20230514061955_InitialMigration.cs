using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinerTech.Infra.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Minerios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Caracteristica = table.Column<string>(type: "varchar(100)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Minerios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargueiros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CapacidadeOcupada = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PesoMinerio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClasseId = table.Column<int>(type: "int", nullable: false),
                    MinerioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargueiros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cargueiros_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cargueiros_Minerios_MinerioId",
                        column: x => x.MinerioId,
                        principalTable: "Minerios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Retornos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataRetorno = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retornos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Retornos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CargueirosQuantidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CargueiroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargueirosQuantidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargueirosQuantidade_Cargueiros_CargueiroId",
                        column: x => x.CargueiroId,
                        principalTable: "Cargueiros",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CargueirosMinerios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MineiroId = table.Column<int>(type: "int", nullable: false),
                    MinerioId = table.Column<int>(type: "int", nullable: false),
                    CargueiroId = table.Column<int>(type: "int", nullable: false),
                    RetornoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargueirosMinerios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargueirosMinerios_Cargueiros_CargueiroId",
                        column: x => x.CargueiroId,
                        principalTable: "Cargueiros",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CargueirosMinerios_Minerios_MinerioId",
                        column: x => x.MinerioId,
                        principalTable: "Minerios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CargueirosMinerios_Retornos_RetornoId",
                        column: x => x.RetornoId,
                        principalTable: "Retornos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RetornosHistorico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantidadeAnterior = table.Column<int>(type: "int", nullable: false),
                    QuantidadeAtual = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    DateCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CargueiroId = table.Column<int>(type: "int", nullable: false),
                    MinerioId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    RetornoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetornosHistorico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RetornosHistorico_Cargueiros_CargueiroId",
                        column: x => x.CargueiroId,
                        principalTable: "Cargueiros",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RetornosHistorico_Minerios_MinerioId",
                        column: x => x.MinerioId,
                        principalTable: "Minerios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RetornosHistorico_Retornos_RetornoId",
                        column: x => x.RetornoId,
                        principalTable: "Retornos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RetornosHistorico_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cargueiros_ClasseId",
                table: "Cargueiros",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargueiros_MinerioId",
                table: "Cargueiros",
                column: "MinerioId");

            migrationBuilder.CreateIndex(
                name: "IX_CargueirosMinerios_CargueiroId",
                table: "CargueirosMinerios",
                column: "CargueiroId");

            migrationBuilder.CreateIndex(
                name: "IX_CargueirosMinerios_MinerioId",
                table: "CargueirosMinerios",
                column: "MinerioId");

            migrationBuilder.CreateIndex(
                name: "IX_CargueirosMinerios_RetornoId",
                table: "CargueirosMinerios",
                column: "RetornoId");

            migrationBuilder.CreateIndex(
                name: "IX_CargueirosQuantidade_CargueiroId",
                table: "CargueirosQuantidade",
                column: "CargueiroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Retornos_UsuarioId",
                table: "Retornos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_RetornosHistorico_CargueiroId",
                table: "RetornosHistorico",
                column: "CargueiroId");

            migrationBuilder.CreateIndex(
                name: "IX_RetornosHistorico_MinerioId",
                table: "RetornosHistorico",
                column: "MinerioId");

            migrationBuilder.CreateIndex(
                name: "IX_RetornosHistorico_RetornoId",
                table: "RetornosHistorico",
                column: "RetornoId");

            migrationBuilder.CreateIndex(
                name: "IX_RetornosHistorico_UsuarioId",
                table: "RetornosHistorico",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargueirosMinerios");

            migrationBuilder.DropTable(
                name: "CargueirosQuantidade");

            migrationBuilder.DropTable(
                name: "RetornosHistorico");

            migrationBuilder.DropTable(
                name: "Cargueiros");

            migrationBuilder.DropTable(
                name: "Retornos");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Minerios");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
