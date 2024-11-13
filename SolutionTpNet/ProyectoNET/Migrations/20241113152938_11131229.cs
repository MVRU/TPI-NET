using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoNET.Migrations
{
    /// <inheritdoc />
    public partial class _11131229 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Subjects_SubjectId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Subjects_SubjectId",
                table: "Courses",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Subjects_SubjectId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Subjects_SubjectId",
                table: "Courses",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
