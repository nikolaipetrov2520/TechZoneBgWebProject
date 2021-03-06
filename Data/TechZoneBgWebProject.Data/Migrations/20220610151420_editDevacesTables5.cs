using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechZoneBgWebProject.Data.Migrations
{
    public partial class editDevacesTables5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Checks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevicesModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevicesModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DevicesModels_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Imei = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceModelId = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConditionId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devices_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devices_DevicesModels_DeviceModelId",
                        column: x => x.DeviceModelId,
                        principalTable: "DevicesModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devices_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckList_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckListsChecks",
                columns: table => new
                {
                    CheckListId = table.Column<int>(type: "int", nullable: false),
                    CheckId = table.Column<int>(type: "int", nullable: false),
                    Condition = table.Column<bool>(type: "bit", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckListsChecks", x => new { x.CheckListId, x.CheckId });
                    table.ForeignKey(
                        name: "FK_CheckListsChecks_CheckList_CheckListId",
                        column: x => x.CheckListId,
                        principalTable: "CheckList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CheckListsChecks_Checks_CheckId",
                        column: x => x.CheckId,
                        principalTable: "Checks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckList_DeviceId",
                table: "CheckList",
                column: "DeviceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CheckListsChecks_CheckId",
                table: "CheckListsChecks",
                column: "CheckId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_AuthorId",
                table: "Devices",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_ConditionId",
                table: "Devices",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DeviceModelId",
                table: "Devices",
                column: "DeviceModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_StatusId",
                table: "Devices",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_DevicesModels_BrandId",
                table: "DevicesModels",
                column: "BrandId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartProduct");

            migrationBuilder.DropTable(
                name: "CheckListsChecks");

            migrationBuilder.DropTable(
                name: "MainNews");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "PostReactions");

            migrationBuilder.DropTable(
                name: "PostReports");

            migrationBuilder.DropTable(
                name: "PostsTags");

            migrationBuilder.DropTable(
                name: "ReplyReactions");

            migrationBuilder.DropTable(
                name: "ReplyReports");

            migrationBuilder.DropTable(
                name: "UsersFollowers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CheckList");

            migrationBuilder.DropTable(
                name: "Checks");

            migrationBuilder.DropTable(
                name: "MainNewsSources");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Replies");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "DevicesModels");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
