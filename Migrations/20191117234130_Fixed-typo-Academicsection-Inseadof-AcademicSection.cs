using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class FixedtypoAcademicsectionInseadofAcademicSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exam_AcademicSecion_AcademicSectionId",
                table: "Exam");

            migrationBuilder.DropForeignKey(
                name: "FK_Exam_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Exam");

            migrationBuilder.DropTable(
                name: "AcademicSecion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exam",
                table: "Exam");

            migrationBuilder.RenameTable(
                name: "Exam",
                newName: "Exams");

            migrationBuilder.RenameIndex(
                name: "IX_Exam_AcademicSectionId",
                table: "Exams",
                newName: "IX_Exams_AcademicSectionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exams",
                table: "Exams",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjecttId", "StudentId", "AcademicSectionId" });

            migrationBuilder.CreateTable(
                name: "AcademicSections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeginDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<Guid>(nullable: false),
                    DepartmentSubjectId = table.Column<int>(nullable: false),
                    DepartmentSubjectDepartmentId = table.Column<int>(nullable: true),
                    DepartmentSubjectSubjectId = table.Column<int>(nullable: true),
                    AcademicSection = table.Column<int>(nullable: false),
                    AcademicSecionId = table.Column<int>(nullable: true),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tests_AcademicSections_AcademicSecionId",
                        column: x => x.AcademicSecionId,
                        principalTable: "AcademicSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tests_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId",
                        columns: x => new { x.DepartmentSubjectDepartmentId, x.DepartmentSubjectSubjectId },
                        principalTable: "DepartmentSubject",
                        principalColumns: new[] { "DepartmentId", "SubjectId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_AcademicSecionId",
                table: "Tests",
                column: "AcademicSecionId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId",
                table: "Tests",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjectId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_AcademicSections_AcademicSectionId",
                table: "Exams",
                column: "AcademicSectionId",
                principalTable: "AcademicSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Exams",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjecttId" },
                principalTable: "DepartmentSubject",
                principalColumns: new[] { "DepartmentId", "SubjectId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_AcademicSections_AcademicSectionId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Exams");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "AcademicSections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exams",
                table: "Exams");

            migrationBuilder.RenameTable(
                name: "Exams",
                newName: "Exam");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_AcademicSectionId",
                table: "Exam",
                newName: "IX_Exam_AcademicSectionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exam",
                table: "Exam",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjecttId", "StudentId", "AcademicSectionId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_AcademicSecion_AcademicSectionId",
                table: "Exam",
                column: "AcademicSectionId",
                principalTable: "AcademicSecion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Exam",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjecttId" },
                principalTable: "DepartmentSubject",
                principalColumns: new[] { "DepartmentId", "SubjectId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
