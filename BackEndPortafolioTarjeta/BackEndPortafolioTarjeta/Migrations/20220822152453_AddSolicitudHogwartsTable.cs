using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndPortafolioTarjeta.Migrations
{
    public partial class AddSolicitudHogwartsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SolicitudHogwarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Identificacion = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Edad = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudHogwarts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SolicitudHogwarts");
        }
    }
}
