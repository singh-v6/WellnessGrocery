using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WellnessGrocery.Data.Migrations
{
    public partial class PurchaseHistorys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_PurchaseHistory_CustomerPurchaseHistoryId",
                table: "Customer");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerPurchaseHistoryId",
                table: "Customer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_PurchaseHistory_CustomerPurchaseHistoryId",
                table: "Customer",
                column: "CustomerPurchaseHistoryId",
                principalTable: "PurchaseHistory",
                principalColumn: "PurchaseHistoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_PurchaseHistory_CustomerPurchaseHistoryId",
                table: "Customer");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerPurchaseHistoryId",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_PurchaseHistory_CustomerPurchaseHistoryId",
                table: "Customer",
                column: "CustomerPurchaseHistoryId",
                principalTable: "PurchaseHistory",
                principalColumn: "PurchaseHistoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
