using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class AddTerm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_AcademicSections_AcademicSectionId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_AcademicSections_AcademicSecionId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_AcademicSecionId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "AcademicSecionId",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "AcademicSection",
                table: "Tests",
                newName: "TermId");

            migrationBuilder.RenameColumn(
                name: "AcademicSectionId",
                table: "Exams",
                newName: "TermId");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_AcademicSectionId",
                table: "Exams",
                newName: "IX_Exams_TermId");

            migrationBuilder.AddColumn<int>(
                name: "Term1Id",
                table: "AcademicSections",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Term2Id",
                table: "AcademicSections",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Term3Id",
                table: "AcademicSections",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "Term",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Term", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_TermId",
                table: "Tests",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicSections_Term1Id",
                table: "AcademicSections",
                column: "Term1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicSections_Term2Id",
                table: "AcademicSections",
                column: "Term2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicSections_Term3Id",
                table: "AcademicSections",
                column: "Term3Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "Term");

            migrationBuilder.DropIndex(
                name: "IX_Tests_TermId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_AcademicSections_Term1Id",
                table: "AcademicSections");

            migrationBuilder.DropIndex(
                name: "IX_AcademicSections_Term2Id",
                table: "AcademicSections");

            migrationBuilder.DropIndex(
                name: "IX_AcademicSections_Term3Id",
                table: "AcademicSections");

            migrationBuilder.DropColumn(
                name: "Term1Id",
                table: "AcademicSections");

            migrationBuilder.DropColumn(
                name: "Term2Id",
                table: "AcademicSections");

            migrationBuilder.DropColumn(
                name: "Term3Id",
                table: "AcademicSections");

            migrationBuilder.DropColumn(
                name: "TermId1",
                table: "AcademicSections");

            migrationBuilder.DropColumn(
                name: "TermId2",
                table: "AcademicSections");

            migrationBuilder.DropColumn(
                name: "TermId3",
                table: "AcademicSections");

            migrationBuilder.RenameColumn(
                name: "TermId",
                table: "Tests",
                newName: "AcademicSection");

            migrationBuilder.RenameColumn(
                name: "TermId",
                table: "Exams",
                newName: "AcademicSectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_TermId",
                table: "Exams",
                newName: "IX_Exams_AcademicSectionId");

            migrationBuilder.AddColumn<int>(
                name: "AcademicSecionId",
                table: "Tests",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tests_AcademicSecionId",
                table: "Tests",
                column: "AcademicSecionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_AcademicSections_AcademicSectionId",
                table: "Exams",
                column: "AcademicSectionId",
                principalTable: "AcademicSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_AcademicSections_AcademicSecionId",
                table: "Tests",
                column: "AcademicSecionId",
                principalTable: "AcademicSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
