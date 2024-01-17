using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShawarmaHousePortal.Data.Migrations
{
    public partial class Extraidadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Extraid",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Extraid",
                table: "Employees");
        }
    }
}
