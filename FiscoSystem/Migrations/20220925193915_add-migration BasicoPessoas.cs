using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiscoSystem.Migrations
{
    public partial class addmigrationBasicoPessoas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabelaPessoas",
                columns: table => new
                {
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NomeFantasia = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Cep = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    Numero = table.Column<int>(type: "int", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaPessoas", x => x.PessoaId);
                });

            migrationBuilder.CreateTable(
                name: "TabelaTelefones",
                columns: table => new
                {
                    TelefoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelefonePrefixo = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    TelefoneNumero = table.Column<long>(type: "bigint", maxLength: 9, nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaTelefones", x => x.TelefoneId);
                    table.ForeignKey(
                        name: "FK_TabelaTelefones_TabelaPessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "TabelaPessoas",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TabelaTelefones_PessoaId",
                table: "TabelaTelefones",
                column: "PessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelaTelefones");

            migrationBuilder.DropTable(
                name: "TabelaPessoas");
        }
    }
}
