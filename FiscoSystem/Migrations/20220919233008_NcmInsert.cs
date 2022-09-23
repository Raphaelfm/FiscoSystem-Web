using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiscoSystem.Migrations
{
    public partial class NcmInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TabelaNcm (CodigoNcm, DescricaoNcm, UnNcm, Usuario, Terminal, Data, Nivel1, Nivel2, Nivel3, Versao) VALUES ('0101', 'Cavalos, asininos e muares, vivos', '', NULL, NULL, NULL, '0101', '', '', 220204)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
