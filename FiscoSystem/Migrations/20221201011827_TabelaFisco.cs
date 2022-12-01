using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiscoSystem.Migrations
{
    public partial class TabelaFisco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabelaFisco",
                columns: table => new
                {
                    FiscoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grupo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Ncm = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Aliquota = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Forma_Tributacao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CST = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    forma_Pis_Cofins = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaFisco", x => x.FiscoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelaFisco");
        }
    }
}
