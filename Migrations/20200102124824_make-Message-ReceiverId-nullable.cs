using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class makeMessageReceiverIdnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ReceiverId",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(Guid));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ReceiverId",
                table: "Messages",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);
        }
    }
}
