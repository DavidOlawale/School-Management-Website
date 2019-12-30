using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class fixedtypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "DepartmentSubjectSubjecttId",
                table: "Exams",
                newName: "DepartmentSubjectSubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId",
                table: "Exams",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjectId" },
                principalTable: "departmentSubjects",
                principalColumns: new[] { "DepartmentId", "SubjectId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "DepartmentSubjectSubjectId",
                table: "Exams",
                newName: "DepartmentSubjectSubjecttId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Exams",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjecttId" },
                principalTable: "departmentSubjects",
                principalColumns: new[] { "DepartmentId", "SubjectId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
