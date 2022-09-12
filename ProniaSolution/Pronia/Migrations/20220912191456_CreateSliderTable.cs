﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Pronia.Migrations
{
    public partial class CreateSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubTitle = table.Column<string>(maxLength: 30, nullable: true),
                    Title = table.Column<string>(maxLength: 20, nullable: true),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    BtnText = table.Column<string>(maxLength: 20, nullable: true),
                    BtnUrl = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
