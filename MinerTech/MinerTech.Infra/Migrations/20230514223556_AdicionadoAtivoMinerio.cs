using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinerTech.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionadoAtivoMinerio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Minerios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Minerios");
        }
    }
}
