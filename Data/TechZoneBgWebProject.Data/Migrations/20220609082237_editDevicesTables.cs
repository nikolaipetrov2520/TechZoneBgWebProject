using Microsoft.EntityFrameworkCore.Migrations;

namespace TechZoneBgWebProject.Data.Migrations
{
    public partial class editDevicesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckListDevices");

            migrationBuilder.AddColumn<int>(
                name: "CheckListId",
                table: "Devices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Devices_CheckListId",
                table: "Devices",
                column: "CheckListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_CheckList_CheckListId",
                table: "Devices",
                column: "CheckListId",
                principalTable: "CheckList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_CheckList_CheckListId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_CheckListId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "CheckListId",
                table: "Devices");

            migrationBuilder.CreateTable(
                name: "CheckListDevices",
                columns: table => new
                {
                    CheckListsId = table.Column<int>(type: "int", nullable: false),
                    DevicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckListDevices", x => new { x.CheckListsId, x.DevicesId });
                    table.ForeignKey(
                        name: "FK_CheckListDevices_CheckList_CheckListsId",
                        column: x => x.CheckListsId,
                        principalTable: "CheckList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CheckListDevices_Devices_DevicesId",
                        column: x => x.DevicesId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckListDevices_DevicesId",
                table: "CheckListDevices",
                column: "DevicesId");
        }
    }
}
