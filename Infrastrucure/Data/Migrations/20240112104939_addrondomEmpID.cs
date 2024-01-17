using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShawarmaHousePortal.Data.Migrations
{
    public partial class addrondomEmpID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RandomEmpid",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RandomEmpid",
                table: "Employees");
        }
    }
}
