using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class AddExamandTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "DepartmentSubject");

            migrationBuilder.CreateTable(
                name: "AcademicSecion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeginDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicSecion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(nullable: false),
                    DepartmentSubjectDepartmentId = table.Column<int>(nullable: false),
                    DepartmentSubjectSubjecttId = table.Column<int>(nullable: false),
                    AcademicSectionId = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => new { x.DepartmentSubjectDepartmentId, x.DepartmentSubjectSubjecttId, x.StudentId, x.AcademicSectionId });
                    table.ForeignKey(
                        name: "FK_Exam_AcademicSecion_AcademicSectionId",
                        column: x => x.AcademicSectionId,
                        principalTable: "AcademicSecion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exam_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                        columns: x => new { x.DepartmentSubjectDepartmentId, x.DepartmentSubjectSubjecttId },
                        principalTable: "DepartmentSubject",
                        principalColumns: new[] { "DepartmentId", "SubjectId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exam_AcademicSectionId",
                table: "Exam",
                column: "AcademicSectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "AcademicSecion");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DepartmentSubject",
                nullable: false,
                defaultValue: 0);
        }
    }
}
