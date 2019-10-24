using Microsoft.EntityFrameworkCore.Migrations;

namespace APIIBU.Migrations
{
    public partial class MigracionBUI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Empleado",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "EmpresaID",
                table: "Empleado",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Num_int",
                table: "Empleado",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Empleado",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "reloj",
                table: "Empleado",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpresaID",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "Num_int",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "reloj",
                table: "Empleado");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Empleado",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
