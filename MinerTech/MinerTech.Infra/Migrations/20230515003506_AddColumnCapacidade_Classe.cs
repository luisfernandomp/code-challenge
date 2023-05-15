using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinerTech.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnCapacidade_Classe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacidade",
                table: "Cargueiros");

            migrationBuilder.AddColumn<decimal>(
                name: "Capacidade",
                table: "Classes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacidade",
                table: "Classes");

            migrationBuilder.AddColumn<decimal>(
                name: "Capacidade",
                table: "Cargueiros",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
