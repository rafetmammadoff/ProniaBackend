using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pronia.Migrations
{
    public partial class UpdateTimeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Products");
        }
    }
}
