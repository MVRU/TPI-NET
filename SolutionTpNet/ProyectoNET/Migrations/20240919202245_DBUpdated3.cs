using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoNET.Migrations
{
    /// <inheritdoc />
    public partial class DBUpdated3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Legajo",
                table: "Users",
                newName: "File");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "File",
                table: "Users",
                newName: "Legajo");
        }
    }
}
