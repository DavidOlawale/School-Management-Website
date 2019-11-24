using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class AddDepartmentSubjectToDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentSubject_Departments_DepartmentId",
                table: "DepartmentSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentSubject_Subjects_SubjectId",
                table: "DepartmentSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentSubject",
                table: "DepartmentSubject");

            migrationBuilder.RenameTable(
                name: "DepartmentSubject",
                newName: "departmentSubjects");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentSubject_SubjectId",
                table: "departmentSubjects",
                newName: "IX_departmentSubjects_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departmentSubjects",
                table: "departmentSubjects",
                columns: new[] { "DepartmentId", "SubjectId" });

            migrationBuilder.AddForeignKey(
                name: "FK_departmentSubjects_Departments_DepartmentId",
                table: "departmentSubjects",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_departmentSubjects_Subjects_SubjectId",
                table: "departmentSubjects",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Exams",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjecttId" },
                principalTable: "departmentSubjects",
                principalColumns: new[] { "DepartmentId", "SubjectId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Tests",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjecttId" },
                principalTable: "departmentSubjects",
                principalColumns: new[] { "DepartmentId", "SubjectId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departmentSubjects_Departments_DepartmentId",
                table: "departmentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_departmentSubjects_Subjects_SubjectId",
                table: "departmentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departmentSubjects",
                table: "departmentSubjects");

            migrationBuilder.RenameTable(
                name: "departmentSubjects",
                newName: "DepartmentSubject");

            migrationBuilder.RenameIndex(
                name: "IX_departmentSubjects_SubjectId",
                table: "DepartmentSubject",
                newName: "IX_DepartmentSubject_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentSubject",
                table: "DepartmentSubject",
                columns: new[] { "DepartmentId", "SubjectId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentSubject_Departments_DepartmentId",
                table: "DepartmentSubject",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentSubject_Subjects_SubjectId",
                table: "DepartmentSubject",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Exams",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjecttId" },
                principalTable: "DepartmentSubject",
                principalColumns: new[] { "DepartmentId", "SubjectId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Tests",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjecttId" },
                principalTable: "DepartmentSubject",
                principalColumns: new[] { "DepartmentId", "SubjectId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
