using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoNET.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAverageAttendancePercentageFromSubject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "File",
                keyValue: "000000");

            migrationBuilder.DropColumn(
                name: "AverageAttendancePercentage",
                table: "Subjects");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "AverageAttendancePercentage",
                table: "Subjects",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "File", "Address", "Email", "LastName", "Name", "Password", "Position", "Role", "Specialization" },
                values: new object[] { "000000", "Address", "admin@example.com", "Principal", "Admin", "$2a$10$5FZX2/9I4OQ/L1I5OFdHo.4omImiWUJcCUp.WAcy.2LMZr2JYFl6i", "Administrador Principal", "Admin Principal", null });
        }
    }
}
