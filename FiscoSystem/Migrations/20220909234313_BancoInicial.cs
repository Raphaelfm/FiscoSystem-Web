using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiscoSystem.Migrations
{
    public partial class BancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CFOP",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cfop = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DescricaoCompleta = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Versao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CFOP", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "TabelaNCM",
                columns: table => new
                {
                    NcmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoNcm = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    DescricaoNcm = table.Column<string>(type: "nvarchar(1200)", maxLength: 1200, nullable: true),
                    UnNcm = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Terminal = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nivel1 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Nivel2 = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Nivel3 = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Versao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaNCM", x => x.NcmId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CFOP");

            migrationBuilder.DropTable(
                name: "TabelaNCM");
        }
    }
}
