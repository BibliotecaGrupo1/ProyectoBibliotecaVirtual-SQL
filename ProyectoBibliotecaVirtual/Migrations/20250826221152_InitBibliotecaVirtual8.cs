using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoBibliotecaVirtual.Migrations
{
    /// <inheritdoc />
    public partial class InitBibliotecaVirtual8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SesionUsuarioId",
                table: "LIBROS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LIBROS_SesionUsuarioId",
                table: "LIBROS",
                column: "SesionUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_LIBROS_SESION_USUARIOS_SesionUsuarioId",
                table: "LIBROS",
                column: "SesionUsuarioId",
                principalTable: "SESION_USUARIOS",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LIBROS_SESION_USUARIOS_SesionUsuarioId",
                table: "LIBROS");

            migrationBuilder.DropIndex(
                name: "IX_LIBROS_SesionUsuarioId",
                table: "LIBROS");

            migrationBuilder.DropColumn(
                name: "SesionUsuarioId",
                table: "LIBROS");
        }
    }
}
