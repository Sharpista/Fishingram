using Microsoft.EntityFrameworkCore.Migrations;

namespace Fishingram.DataAccess.Migrations
{
    public partial class terceiramigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoAlbums_Profiles_UserProfileId",
                table: "PhotoAlbums");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Profiles_UserProfileId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.RenameColumn(
                name: "UserProfileId",
                table: "Posts",
                newName: "ProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_UserProfileId",
                table: "Posts",
                newName: "IX_Posts_ProfileId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Profiles_ProfileId",
                table: "Posts",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoAlbums_Profiles_ProfileId",
                table: "PhotoAlbums");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Profiles_ProfileId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Posts",
                newName: "UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_ProfileId",
                table: "Posts",
                newName: "IX_Posts_UserProfileId");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "PhotoAlbums",
                newName: "UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_PhotoAlbums_ProfileId",
                table: "PhotoAlbums",
                newName: "IX_PhotoAlbums_UserProfileId");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Profiles_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_SenderId",
                table: "Notifications",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoAlbums_Profiles_UserProfileId",
                table: "PhotoAlbums",
                column: "UserProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Profiles_UserProfileId",
                table: "Posts",
                column: "UserProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
