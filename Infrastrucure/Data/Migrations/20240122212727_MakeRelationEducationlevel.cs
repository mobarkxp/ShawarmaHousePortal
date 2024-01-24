using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShawarmaHousePortal.Data.Migrations
{
    public partial class MakeRelationEducationlevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EName",
                table: "Educations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_EName",
                table: "Educations",
                column: "EName");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_EducationLevels_EName",
                table: "Educations",
                column: "EName",
                principalTable: "EducationLevels",
                principalColumn: "EducationLevelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_EducationLevels_EName",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_EName",
                table: "Educations");

            migrationBuilder.AlterColumn<string>(
                name: "EName",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
