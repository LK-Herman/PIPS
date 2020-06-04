using Microsoft.EntityFrameworkCore.Migrations;

namespace PipsiProject.Migrations
{
    public partial class SeparCarAndImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ImageTitle",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Images",
                newName: "ImageTitle");

            migrationBuilder.AddColumn<int>(
                name: "CarimgIdImageId",
                table: "Cars",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarimgIdImageId",
                table: "Cars",
                column: "CarimgIdImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Images_CarimgIdImageId",
                table: "Cars",
                column: "CarimgIdImageId",
                principalTable: "Images",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Images_CarimgIdImageId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CarimgIdImageId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarimgIdImageId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "ImageTitle",
                table: "Images",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Cars",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageTitle",
                table: "Cars",
                type: "nvarchar(50)",
                nullable: true);
        }
    }
}
