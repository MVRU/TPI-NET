using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoNET.Migrations
{
    /// <inheritdoc />
    public partial class DBUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseProfessor_Users_ProfessorId",
                table: "CourseProfessor");

            migrationBuilder.DropColumn(
                name: "ProfessorFile",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StudentFile",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "Legajo");

            migrationBuilder.RenameColumn(
                name: "ProfessorId",
                table: "CourseProfessor",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseProfessor_ProfessorId",
                table: "CourseProfessor",
                newName: "IX_CourseProfessor_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Specialization",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProfessor_Users_UserId",
                table: "CourseProfessor",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Legajo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseProfessor_Users_UserId",
                table: "CourseProfessor");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Legajo",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CourseProfessor",
                newName: "ProfessorId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseProfessor_UserId",
                table: "CourseProfessor",
                newName: "IX_CourseProfessor_ProfessorId");

            migrationBuilder.AlterColumn<string>(
                name: "Specialization",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ProfessorFile",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentFile",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProfessor_Users_ProfessorId",
                table: "CourseProfessor",
                column: "ProfessorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
