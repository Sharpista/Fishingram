using Microsoft.EntityFrameworkCore.Migrations;

namespace Fishingram.DataAccess.Migrations
{
    public partial class segundamigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoAlbums_Profiles_ProfileId",
                table: "PhotoAlbums");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "PhotoAlbums",
                newName: "UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_PhotoAlbums_ProfileId",
                table: "PhotoAlbums",
                newName: "IX_PhotoAlbums_UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoAlbums_Profiles_UserProfileId",
                table: "PhotoAlbums",
                column: "UserProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoAlbums_Profiles_UserProfileId",
                table: "PhotoAlbums");

            migrationBuilder.RenameColumn(
                name: "UserProfileId",
                table: "PhotoAlbums",
                newName: "ProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_PhotoAlbums_UserProfileId",
                table: "PhotoAlbums",
                newName: "IX_PhotoAlbums_ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoAlbums_Profiles_ProfileId",
                table: "PhotoAlbums",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
