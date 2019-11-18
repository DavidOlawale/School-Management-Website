using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class TestClassRepaired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tests",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "DepartmentSubjectId",
                table: "Tests",
                newName: "DepartmentSubjectSubjecttId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentSubjectSubjectId",
                table: "Tests",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentSubjectDepartmentId",
                table: "Tests",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tests",
                table: "Tests",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjecttId", "StudentId", "TermId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Tests",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjecttId" },
                principalTable: "DepartmentSubject",
                principalColumns: new[] { "DepartmentId", "SubjectId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tests",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "DepartmentSubjectSubjecttId",
                table: "Tests",
                newName: "DepartmentSubjectId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentSubjectSubjectId",
                table: "Tests",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentSubjectDepartmentId",
                table: "Tests",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Tests",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tests",
                table: "Tests",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId",
                table: "Tests",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjectId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId",
                table: "Tests",
                columns: new[] { "DepartmentSubjectDepartmentId", "DepartmentSubjectSubjectId" },
                principalTable: "DepartmentSubject",
                principalColumns: new[] { "DepartmentId", "SubjectId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
