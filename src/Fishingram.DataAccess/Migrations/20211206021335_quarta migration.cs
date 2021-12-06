using Microsoft.EntityFrameworkCore.Migrations;

namespace Fishingram.DataAccess.Migrations
{
    public partial class quartamigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Profiles");

            migrationBuilder.AddColumn<long>(
                name: "LoginId",
                table: "Profiles",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_LoginId",
                table: "Profiles",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Login_Email",
                table: "Login",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Login_LoginId",
                table: "Profiles",
                column: "LoginId",
                principalTable: "Login",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Login_LoginId",
                table: "Profiles");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_LoginId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "LoginId",
                table: "Profiles");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Profiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
