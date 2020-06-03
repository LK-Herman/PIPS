using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PipsiProject.Migrations
{
    public partial class ChangeBookDbTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BigImage",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SmImage",
                table: "Cars");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Images",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ImageTitle",
                table: "Cars");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Images",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "BigImage",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "SmImage",
                table: "Cars",
                nullable: true);
        }
    }
}
