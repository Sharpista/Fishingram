using Microsoft.EntityFrameworkCore.Migrations;

namespace Fishingram.DataAccess.Migrations
{
    public partial class terceiramigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address_District",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address_District",
                table: "Profiles");
        }
    }
}
