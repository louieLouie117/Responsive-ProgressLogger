using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgressLog.Migrations
{
    public partial class AccountTypeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountType",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MeetUpLink",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileBackground",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileImg",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserTitle",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MeetUpLink",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProfileBackground",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProfileImg",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserTitle",
                table: "Users");
        }
    }
}
