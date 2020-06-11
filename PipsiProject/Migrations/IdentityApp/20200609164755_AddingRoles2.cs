using Microsoft.EntityFrameworkCore.Migrations;

namespace PipsiProject.Migrations.IdentityApp
{
    public partial class AddingRoles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "AspNetRoles");

            migrationBuilder.RenameColumn(
                name: "RoleDesc",
                table: "AspNetRoles",
                newName: "RoleDescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoleDescription",
                table: "AspNetRoles",
                newName: "RoleDesc");

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "AspNetRoles",
                type: "nvarchar(6)",
                nullable: true);
        }
    }
}
