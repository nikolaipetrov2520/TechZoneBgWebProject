using Microsoft.EntityFrameworkCore.Migrations;

namespace TechZoneBgWebProject.Data.Migrations
{
    public partial class CartProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_Carts_CartsId",
                table: "CartProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_Products_ProductsId",
                table: "CartProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartProduct",
                table: "CartProduct");

            migrationBuilder.DropIndex(
                name: "IX_CartProduct_ProductsId",
                table: "CartProduct");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "CartProduct",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "CartsId",
                table: "CartProduct",
                newName: "ProductId");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "CartProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartProduct",
                table: "CartProduct",
                columns: new[] { "CartId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_ProductId",
                table: "CartProduct",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_Carts_CartId",
                table: "CartProduct",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_Products_ProductId",
                table: "CartProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_Carts_CartId",
                table: "CartProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_Products_ProductId",
                table: "CartProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartProduct",
                table: "CartProduct");

            migrationBuilder.DropIndex(
                name: "IX_CartProduct_ProductId",
                table: "CartProduct");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "CartProduct");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "CartProduct",
                newName: "ProductsId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "CartProduct",
                newName: "CartsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartProduct",
                table: "CartProduct",
                columns: new[] { "CartsId", "ProductsId" });

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_ProductsId",
                table: "CartProduct",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_Carts_CartsId",
                table: "CartProduct",
                column: "CartsId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_Products_ProductsId",
                table: "CartProduct",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
