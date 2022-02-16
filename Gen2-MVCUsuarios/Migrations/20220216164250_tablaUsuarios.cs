using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gen2_MVCUsuarios.Migrations
{
    public partial class tablaUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 20, nullable: false),
                    ApPaterno = table.Column<string>(maxLength: 20, nullable: false),
                    ApMaterno = table.Column<string>(maxLength: 20, nullable: false),
                    Telefono = table.Column<string>(maxLength: 15, nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    FechaNac = table.Column<DateTime>(nullable: false),
                    Direccion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
