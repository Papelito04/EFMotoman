using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFMotoman.Migrations
{
    public partial class todo5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Personas",
                newName: "TipoPersona");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoPersona",
                table: "Personas",
                newName: "Discriminator");
        }
    }
}
