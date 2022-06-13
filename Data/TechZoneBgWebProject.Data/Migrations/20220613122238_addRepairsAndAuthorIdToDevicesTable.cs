using Microsoft.EntityFrameworkCore.Migrations;

namespace TechZoneBgWebProject.Data.Migrations
{
    public partial class addRepairsAndAuthorIdToDevicesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Repair",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Repair",
                table: "Devices");
        }
    }
}
