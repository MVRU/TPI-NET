using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoNET.Migrations
{
    /// <inheritdoc />
    public partial class AllowNullCourseId2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "File",
                keyValue: "000000",
                column: "Password",
                value: "$2a$10$5FZX2/9I4OQ/L1I5OFdHo.4omImiWUJcCUp.WAcy.2LMZr2JYFl6i");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "File",
                keyValue: "000000",
                column: "Password",
                value: "$2b$12$LsaagJ1caYoRBMtKO1rat.AjIfIrWUYafqn55uPuGwu3QWyAmGQwy");
        }
    }
}
