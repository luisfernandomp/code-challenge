using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinerTech.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AlterDeleteBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargueiros_Classes_ClasseId",
                table: "Cargueiros");

            migrationBuilder.DropForeignKey(
                name: "FK_Cargueiros_Minerios_MinerioId",
                table: "Cargueiros");

            migrationBuilder.DropForeignKey(
                name: "FK_CargueirosMinerios_Cargueiros_CargueiroId",
                table: "CargueirosMinerios");

            migrationBuilder.DropForeignKey(
                name: "FK_CargueirosMinerios_Minerios_MinerioId",
                table: "CargueirosMinerios");

            migrationBuilder.DropForeignKey(
                name: "FK_CargueirosMinerios_Retornos_RetornoId",
                table: "CargueirosMinerios");

            migrationBuilder.DropForeignKey(
                name: "FK_CargueirosQuantidade_Cargueiros_CargueiroId",
                table: "CargueirosQuantidade");

            migrationBuilder.DropForeignKey(
                name: "FK_Retornos_Usuarios_UsuarioId",
                table: "Retornos");

            migrationBuilder.DropForeignKey(
                name: "FK_RetornosHistorico_Cargueiros_CargueiroId",
                table: "RetornosHistorico");

            migrationBuilder.DropForeignKey(
                name: "FK_RetornosHistorico_Minerios_MinerioId",
                table: "RetornosHistorico");

            migrationBuilder.DropForeignKey(
                name: "FK_RetornosHistorico_Retornos_RetornoId",
                table: "RetornosHistorico");

            migrationBuilder.DropForeignKey(
                name: "FK_RetornosHistorico_Usuarios_UsuarioId",
                table: "RetornosHistorico");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargueiros_Classes_ClasseId",
                table: "Cargueiros",
                column: "ClasseId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cargueiros_Minerios_MinerioId",
                table: "Cargueiros",
                column: "MinerioId",
                principalTable: "Minerios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CargueirosMinerios_Cargueiros_CargueiroId",
                table: "CargueirosMinerios",
                column: "CargueiroId",
                principalTable: "Cargueiros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CargueirosMinerios_Minerios_MinerioId",
                table: "CargueirosMinerios",
                column: "MinerioId",
                principalTable: "Minerios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CargueirosMinerios_Retornos_RetornoId",
                table: "CargueirosMinerios",
                column: "RetornoId",
                principalTable: "Retornos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CargueirosQuantidade_Cargueiros_CargueiroId",
                table: "CargueirosQuantidade",
                column: "CargueiroId",
                principalTable: "Cargueiros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Retornos_Usuarios_UsuarioId",
                table: "Retornos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RetornosHistorico_Cargueiros_CargueiroId",
                table: "RetornosHistorico",
                column: "CargueiroId",
                principalTable: "Cargueiros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RetornosHistorico_Minerios_MinerioId",
                table: "RetornosHistorico",
                column: "MinerioId",
                principalTable: "Minerios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RetornosHistorico_Retornos_RetornoId",
                table: "RetornosHistorico",
                column: "RetornoId",
                principalTable: "Retornos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RetornosHistorico_Usuarios_UsuarioId",
                table: "RetornosHistorico",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargueiros_Classes_ClasseId",
                table: "Cargueiros");

            migrationBuilder.DropForeignKey(
                name: "FK_Cargueiros_Minerios_MinerioId",
                table: "Cargueiros");

            migrationBuilder.DropForeignKey(
                name: "FK_CargueirosMinerios_Cargueiros_CargueiroId",
                table: "CargueirosMinerios");

            migrationBuilder.DropForeignKey(
                name: "FK_CargueirosMinerios_Minerios_MinerioId",
                table: "CargueirosMinerios");

            migrationBuilder.DropForeignKey(
                name: "FK_CargueirosMinerios_Retornos_RetornoId",
                table: "CargueirosMinerios");

            migrationBuilder.DropForeignKey(
                name: "FK_CargueirosQuantidade_Cargueiros_CargueiroId",
                table: "CargueirosQuantidade");

            migrationBuilder.DropForeignKey(
                name: "FK_Retornos_Usuarios_UsuarioId",
                table: "Retornos");

            migrationBuilder.DropForeignKey(
                name: "FK_RetornosHistorico_Cargueiros_CargueiroId",
                table: "RetornosHistorico");

            migrationBuilder.DropForeignKey(
                name: "FK_RetornosHistorico_Minerios_MinerioId",
                table: "RetornosHistorico");

            migrationBuilder.DropForeignKey(
                name: "FK_RetornosHistorico_Retornos_RetornoId",
                table: "RetornosHistorico");

            migrationBuilder.DropForeignKey(
                name: "FK_RetornosHistorico_Usuarios_UsuarioId",
                table: "RetornosHistorico");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargueiros_Classes_ClasseId",
                table: "Cargueiros",
                column: "ClasseId",
                principalTable: "Classes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargueiros_Minerios_MinerioId",
                table: "Cargueiros",
                column: "MinerioId",
                principalTable: "Minerios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CargueirosMinerios_Cargueiros_CargueiroId",
                table: "CargueirosMinerios",
                column: "CargueiroId",
                principalTable: "Cargueiros",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CargueirosMinerios_Minerios_MinerioId",
                table: "CargueirosMinerios",
                column: "MinerioId",
                principalTable: "Minerios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CargueirosMinerios_Retornos_RetornoId",
                table: "CargueirosMinerios",
                column: "RetornoId",
                principalTable: "Retornos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CargueirosQuantidade_Cargueiros_CargueiroId",
                table: "CargueirosQuantidade",
                column: "CargueiroId",
                principalTable: "Cargueiros",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Retornos_Usuarios_UsuarioId",
                table: "Retornos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RetornosHistorico_Cargueiros_CargueiroId",
                table: "RetornosHistorico",
                column: "CargueiroId",
                principalTable: "Cargueiros",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RetornosHistorico_Minerios_MinerioId",
                table: "RetornosHistorico",
                column: "MinerioId",
                principalTable: "Minerios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RetornosHistorico_Retornos_RetornoId",
                table: "RetornosHistorico",
                column: "RetornoId",
                principalTable: "Retornos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RetornosHistorico_Usuarios_UsuarioId",
                table: "RetornosHistorico",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
