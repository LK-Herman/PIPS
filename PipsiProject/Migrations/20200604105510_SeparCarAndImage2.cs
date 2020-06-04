using Microsoft.EntityFrameworkCore.Migrations;

namespace PipsiProject.Migrations
{
    public partial class SeparCarAndImage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Images_CarimgIdImageId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "CarimgIdImageId",
                table: "Cars",
                newName: "CarImageImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_CarimgIdImageId",
                table: "Cars",
                newName: "IX_Cars_CarImageImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Images_CarImageImageId",
                table: "Cars",
                column: "CarImageImageId",
                principalTable: "Images",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Images_CarImageImageId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "CarImageImageId",
                table: "Cars",
                newName: "CarimgIdImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_CarImageImageId",
                table: "Cars",
                newName: "IX_Cars_CarimgIdImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Images_CarimgIdImageId",
                table: "Cars",
                column: "CarimgIdImageId",
                principalTable: "Images",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
