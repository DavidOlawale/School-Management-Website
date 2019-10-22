using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class AttendanceIdtoId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AttendanceId",
                table: "Attendances",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Attendances",
                newName: "AttendanceId");
        }
    }
}
