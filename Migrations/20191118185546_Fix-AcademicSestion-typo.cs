using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class FixAcademicSestiontypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TermId1",
                table: "AcademicSections");

            migrationBuilder.DropColumn(
                name: "TermId2",
                table: "AcademicSections");

            migrationBuilder.DropColumn(
                name: "TermId3",
                table: "AcademicSections");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Term",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Term",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Term");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Term");

            migrationBuilder.AddColumn<int>(
                name: "TermId1",
                table: "AcademicSections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TermId2",
                table: "AcademicSections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TermId3",
                table: "AcademicSections",
                nullable: false,
                defaultValue: 0);
        }
    }
}
