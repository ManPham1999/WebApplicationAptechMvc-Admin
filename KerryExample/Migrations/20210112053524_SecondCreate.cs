using Microsoft.EntityFrameworkCore.Migrations;

namespace KerryExample.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CatgoryCatId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatgoryCatId",
                table: "Products",
                column: "CatgoryCatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Catgories_CatgoryCatId",
                table: "Products",
                column: "CatgoryCatId",
                principalTable: "Catgories",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Catgories_CatgoryCatId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CatgoryCatId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CatgoryCatId",
                table: "Products");
        }
    }
}
