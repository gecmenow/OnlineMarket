using Microsoft.EntityFrameworkCore.Migrations;

namespace KramDeliveryFood.Data.Migrations
{
    public partial class fixProducttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Products_ProductsProductID",
                table: "OrderProduct");

            migrationBuilder.DropColumn(
                name: "ProductCount",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "ProductsProductID",
                table: "OrderProduct",
                newName: "ProductsProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProduct_ProductsProductID",
                table: "OrderProduct",
                newName: "IX_OrderProduct_ProductsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Products_ProductsProductId",
                table: "OrderProduct",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Products_ProductsProductId",
                table: "OrderProduct");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "ProductsProductId",
                table: "OrderProduct",
                newName: "ProductsProductID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProduct_ProductsProductId",
                table: "OrderProduct",
                newName: "IX_OrderProduct_ProductsProductID");

            migrationBuilder.AddColumn<int>(
                name: "ProductCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Products_ProductsProductID",
                table: "OrderProduct",
                column: "ProductsProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
