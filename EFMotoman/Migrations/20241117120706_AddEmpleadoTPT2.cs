using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFMotoman.Migrations
{
    public partial class AddEmpleadoTPT2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Personas_EmpleadoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "AreaDeTrabajo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TipoPersona",
                table: "Personas");

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    AreaDeTrabajo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleados_Personas_Id",
                        column: x => x.Id,
                        principalTable: "Personas",
                        principalColumn: "Id");
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Empleados_EmpleadoId",
                table: "Usuarios",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Empleados_EmpleadoId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.AddColumn<string>(
                name: "AreaDeTrabajo",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoPersona",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Personas_EmpleadoId",
                table: "Usuarios",
                column: "EmpleadoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
