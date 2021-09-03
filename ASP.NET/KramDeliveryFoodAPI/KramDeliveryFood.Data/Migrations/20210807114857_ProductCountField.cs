using Microsoft.EntityFrameworkCore.Migrations;

namespace KramDeliveryFood.Data.Migrations
{
    public partial class ProductCountField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.Sql("CREATE TRIGGER UPD ON Products AFTER INSERT AS UPDATE Products SET ProductsCount = 100");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCount",
                table: "Products");
        }
    }
}
