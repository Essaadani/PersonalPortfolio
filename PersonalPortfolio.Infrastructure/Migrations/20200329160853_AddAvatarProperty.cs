using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalPortfolio.Infrastructure.Migrations
{
    public partial class AddAvatarProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Owner",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Owner");
        }
    }
}
