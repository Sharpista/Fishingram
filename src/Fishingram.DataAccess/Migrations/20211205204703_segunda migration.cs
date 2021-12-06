using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fishingram.DataAccess.Migrations
{
    public partial class segundamigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "BinaryContent",
                table: "Photos",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BinaryContent",
                table: "Photos");
        }
    }
}
