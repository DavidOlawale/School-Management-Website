using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class MessageRecieverIdtoReceiverId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecieverId",
                table: "Messages",
                newName: "ReceiverId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReceiverId",
                table: "Messages",
                newName: "RecieverId");
        }
    }
}
