using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class AddMessageToAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ToAdmin",
                table: "Messages",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToAdmin",
                table: "Messages");
        }
    }
}
