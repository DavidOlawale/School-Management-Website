using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class AddApplicationUserHasProfilePhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasProfilePhoto",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasProfilePhoto",
                table: "AspNetUsers");
        }
    }
}
