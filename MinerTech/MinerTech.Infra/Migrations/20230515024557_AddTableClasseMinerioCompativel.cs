using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinerTech.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddTableClasseMinerioCompativel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClasseMineriosCompativeis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinerioId = table.Column<int>(type: "int", nullable: false),
                    ClasseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasseMineriosCompativeis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClasseMineriosCompativeis_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClasseMineriosCompativeis_Minerios_MinerioId",
                        column: x => x.MinerioId,
                        principalTable: "Minerios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClasseMineriosCompativeis_ClasseId",
                table: "ClasseMineriosCompativeis",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_ClasseMineriosCompativeis_MinerioId",
                table: "ClasseMineriosCompativeis",
                column: "MinerioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClasseMineriosCompativeis");
        }
    }
}
