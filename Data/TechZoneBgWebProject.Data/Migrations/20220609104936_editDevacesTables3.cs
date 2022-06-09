using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechZoneBgWebProject.Data.Migrations
{
    public partial class editDevacesTables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Status",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Status",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "DevicesModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DevicesModels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Conditions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Conditions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Checks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Checks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Brands",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Brands",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "DevicesModels");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DevicesModels");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Conditions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Conditions");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Checks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Checks");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Brands");
        }
    }
}
