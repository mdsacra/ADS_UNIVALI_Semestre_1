using Microsoft.EntityFrameworkCore.Migrations;

namespace Adventures.Migrations
{
    public partial class RelacaoClientePacote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PacoteClientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false),
                    PacoteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacoteClientes", x => new { x.ClienteId, x.PacoteId });
                    table.ForeignKey(
                        name: "FK_PacoteClientes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacoteClientes_Pacotes_PacoteId",
                        column: x => x.PacoteId,
                        principalTable: "Pacotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PacoteClientes_PacoteId",
                table: "PacoteClientes",
                column: "PacoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PacoteClientes");
        }
    }
}
