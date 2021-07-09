using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationOnline.Migrations
{
    public partial class CreacionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mountains",
                columns: table => new
                {
                    MountainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer: Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Altitud = table.Column<int>(type: "int", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cordillera = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK Mountains", x => x.MountainId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mountains");
        }
    }
}
