using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class fixspellingerrorr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tests",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "DepartmentSubjectSubjecttId",
                table: "Tests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tests",
                table: "Tests",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjectId", "StudentId", "TermId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId",
                table: "Tests",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjectId" },
                principalTable: "departmentSubjects",
                principalColumns: new[] { "DepartmentId", "SubjectId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tests",
                table: "Tests");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentSubjectSubjecttId",
                table: "Tests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tests",
                table: "Tests",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjecttId", "StudentId", "TermId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Tests",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjecttId" },
                principalTable: "departmentSubjects",
                principalColumns: new[] { "DepartmentId", "SubjectId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
