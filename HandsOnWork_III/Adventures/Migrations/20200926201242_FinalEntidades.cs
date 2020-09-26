using Microsoft.EntityFrameworkCore.Migrations;

namespace Adventures.Migrations
{
    public partial class FinalEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpTrans_RespsEmpresas_ResponsavelId",
                table: "EmpTrans");

            migrationBuilder.AlterColumn<int>(
                name: "ResponsavelId",
                table: "EmpTrans",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpTrans_RespsEmpresas_ResponsavelId",
                table: "EmpTrans",
                column: "ResponsavelId",
                principalTable: "RespsEmpresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpTrans_RespsEmpresas_ResponsavelId",
                table: "EmpTrans");

            migrationBuilder.AlterColumn<int>(
                name: "ResponsavelId",
                table: "EmpTrans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_EmpTrans_RespsEmpresas_ResponsavelId",
                table: "EmpTrans",
                column: "ResponsavelId",
                principalTable: "RespsEmpresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
