using Microsoft.EntityFrameworkCore.Migrations;

namespace Pronia.Migrations
{
    public partial class AddCategoriesTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ProductCategories");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "ProductCategories",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "ProductCategories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
