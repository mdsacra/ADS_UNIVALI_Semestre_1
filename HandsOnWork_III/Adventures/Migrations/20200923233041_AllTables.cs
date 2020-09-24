using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Adventures.Migrations
{
    public partial class AllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dpto",
                table: "Colaboradores",
                newName: "Dpto");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RespsEmpresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespsEmpresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpTrans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Cnpj = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    ResponsavelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpTrans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpTrans_RespsEmpresas_ResponsavelId",
                        column: x => x.ResponsavelId,
                        principalTable: "RespsEmpresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cidade = table.Column<string>(nullable: true),
                    Pais = table.Column<string>(nullable: true),
                    Hotel = table.Column<string>(nullable: true),
                    DtPartida = table.Column<DateTime>(nullable: false),
                    DtRetornoe = table.Column<DateTime>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: true),
                    VlrEstadia = table.Column<double>(nullable: false),
                    VlrTransporte = table.Column<double>(nullable: false),
                    AllInclusive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacotes_EmpTrans_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "EmpTrans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpTrans_ResponsavelId",
                table: "EmpTrans",
                column: "ResponsavelId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacotes_EmpresaId",
                table: "Pacotes",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Pacotes");

            migrationBuilder.DropTable(
                name: "EmpTrans");

            migrationBuilder.DropTable(
                name: "RespsEmpresas");

            migrationBuilder.RenameColumn(
                name: "Dpto",
                table: "Colaboradores",
                newName: "dpto");
        }
    }
}
