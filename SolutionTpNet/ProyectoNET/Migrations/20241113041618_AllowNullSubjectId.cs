using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoNET.Migrations
{
    public partial class AllowNullSubjectId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Modificar la columna 'SubjectId' en la tabla 'Courses' para permitir nulos
            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Courses",
                nullable: true, // Permitir que sea nulo
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Revertir la modificación, es decir, no permitir nulos
            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Courses",
                nullable: false, // No permitir nulos
                oldClrType: typeof(int),
                oldType: "int",
                defaultValue: 0); // Puedes asignar un valor por defecto, por ejemplo, 0
        }
    }
}
