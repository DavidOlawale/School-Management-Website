using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class AddToAllParentsAttribTomessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ToAllParents",
                table: "Messages",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToAllParents",
                table: "Messages");
        }
    }
}
