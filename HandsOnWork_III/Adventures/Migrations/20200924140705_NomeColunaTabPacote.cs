using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Adventures.Migrations
{
    public partial class NomeColunaTabPacote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DtRetornoe",
                table: "Pacotes");

            migrationBuilder.AddColumn<DateTime>(
                name: "DtRetorno",
                table: "Pacotes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DtRetorno",
                table: "Pacotes");

            migrationBuilder.AddColumn<DateTime>(
                name: "DtRetornoe",
                table: "Pacotes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
