using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AL_VALHALLA.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Users",
                newName: "Password");

            migrationBuilder.AddColumn<string>(
                name: "NombreCompleto",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreCompleto",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Nombre");
        }
    }
}
