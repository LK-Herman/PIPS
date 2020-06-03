using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PipsiProject.Migrations
{
    public partial class AddCarsToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marka = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Klasa = table.Column<string>(nullable: true),
                    PojSilnika = table.Column<float>(nullable: false),
                    Przebieg = table.Column<double>(nullable: false),
                    RokProd = table.Column<DateTime>(nullable: false),
                    Paliwo = table.Column<string>(nullable: true),
                    Kolor = table.Column<string>(nullable: true),
                    Cena = table.Column<int>(nullable: false),
                    SmImage = table.Column<byte[]>(nullable: true),
                    BigImage = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
