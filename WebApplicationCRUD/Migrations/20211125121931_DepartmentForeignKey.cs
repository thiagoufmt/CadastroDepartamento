using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationCRUD.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedors_Department_DepartmentId",
                table: "Vendedors");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Vendedors",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedors_Department_DepartmentId",
                table: "Vendedors",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedors_Department_DepartmentId",
                table: "Vendedors");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Vendedors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedors_Department_DepartmentId",
                table: "Vendedors",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
