using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDesk__Mine_.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeskQuote",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clientFirstName = table.Column<string>(nullable: true),
                    clientLastName = table.Column<string>(nullable: true),
                    submitDate = table.Column<DateTime>(nullable: false),
                    quoteTotal = table.Column<double>(nullable: false),
                    deskWidth = table.Column<double>(nullable: false),
                    deskDepth = table.Column<double>(nullable: false),
                    numDrawers = table.Column<int>(nullable: false),
                    surfaceMaterial = table.Column<string>(nullable: true),
                    rushOption = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskQuote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeskQuote");
        }
    }
}
