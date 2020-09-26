using Microsoft.EntityFrameworkCore.Migrations;

namespace Adventures.Migrations
{
    public partial class TesteEmpPacote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacotes_EmpTrans_EmpresaId",
                table: "Pacotes");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Pacotes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacotes_EmpTrans_EmpresaId",
                table: "Pacotes",
                column: "EmpresaId",
                principalTable: "EmpTrans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacotes_EmpTrans_EmpresaId",
                table: "Pacotes");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Pacotes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Pacotes_EmpTrans_EmpresaId",
                table: "Pacotes",
                column: "EmpresaId",
                principalTable: "EmpTrans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
