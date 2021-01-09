using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KerryExample.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catgories",
                columns: table => new
                {
                    CatId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catgories", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    Img = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    CatgoryRefId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catgories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
