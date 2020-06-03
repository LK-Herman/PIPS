using Microsoft.EntityFrameworkCore.Migrations;

namespace PipsiProject.Migrations
{
    public partial class ChangeBookDbTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PojSilnika",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "PojSilnika",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
