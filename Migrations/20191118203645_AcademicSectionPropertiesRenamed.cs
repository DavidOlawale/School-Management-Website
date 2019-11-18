using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class AcademicSectionPropertiesRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicSections_Term_Term1Id",
                table: "AcademicSections");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicSections_Term_Term2Id",
                table: "AcademicSections");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicSections_Term_Term3Id",
                table: "AcademicSections");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Term_TermId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Term_TermId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Term",
                table: "Term");

            migrationBuilder.RenameTable(
                name: "Term",
                newName: "Terms");

            migrationBuilder.RenameColumn(
                name: "Term3Id",
                table: "AcademicSections",
                newName: "ThirdTermId");

            migrationBuilder.RenameColumn(
                name: "Term2Id",
                table: "AcademicSections",
                newName: "SecondTermId");

            migrationBuilder.RenameColumn(
                name: "Term1Id",
                table: "AcademicSections",
                newName: "FirstTermId");

            migrationBuilder.RenameIndex(
                name: "IX_AcademicSections_Term3Id",
                table: "AcademicSections",
                newName: "IX_AcademicSections_ThirdTermId");

            migrationBuilder.RenameIndex(
                name: "IX_AcademicSections_Term2Id",
                table: "AcademicSections",
                newName: "IX_AcademicSections_SecondTermId");

            migrationBuilder.RenameIndex(
                name: "IX_AcademicSections_Term1Id",
                table: "AcademicSections",
                newName: "IX_AcademicSections_FirstTermId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Terms",
                table: "Terms",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicSections_Terms_FirstTermId",
                table: "AcademicSections",
                column: "FirstTermId",
                principalTable: "Terms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicSections_Terms_SecondTermId",
                table: "AcademicSections",
                column: "SecondTermId",
                principalTable: "Terms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicSections_Terms_ThirdTermId",
                table: "AcademicSections",
                column: "ThirdTermId",
                principalTable: "Terms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Terms_TermId",
                table: "Exams",
                column: "TermId",
                principalTable: "Terms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Terms_TermId",
                table: "Tests",
                column: "TermId",
                principalTable: "Terms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicSections_Terms_FirstTermId",
                table: "AcademicSections");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicSections_Terms_SecondTermId",
                table: "AcademicSections");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicSections_Terms_ThirdTermId",
                table: "AcademicSections");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Terms_TermId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Terms_TermId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Terms",
                table: "Terms");

            migrationBuilder.RenameTable(
                name: "Terms",
                newName: "Term");

            migrationBuilder.RenameColumn(
                name: "ThirdTermId",
                table: "AcademicSections",
                newName: "Term3Id");

            migrationBuilder.RenameColumn(
                name: "SecondTermId",
                table: "AcademicSections",
                newName: "Term2Id");

            migrationBuilder.RenameColumn(
                name: "FirstTermId",
                table: "AcademicSections",
                newName: "Term1Id");

            migrationBuilder.RenameIndex(
                name: "IX_AcademicSections_ThirdTermId",
                table: "AcademicSections",
                newName: "IX_AcademicSections_Term3Id");

            migrationBuilder.RenameIndex(
                name: "IX_AcademicSections_SecondTermId",
                table: "AcademicSections",
                newName: "IX_AcademicSections_Term2Id");

            migrationBuilder.RenameIndex(
                name: "IX_AcademicSections_FirstTermId",
                table: "AcademicSections",
                newName: "IX_AcademicSections_Term1Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Term",
                table: "Term",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicSections_Term_Term1Id",
                table: "AcademicSections",
                column: "Term1Id",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicSections_Term_Term2Id",
                table: "AcademicSections",
                column: "Term2Id",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicSections_Term_Term3Id",
                table: "AcademicSections",
                column: "Term3Id",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Term_TermId",
                table: "Exams",
                column: "TermId",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Term_TermId",
                table: "Tests",
                column: "TermId",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
