using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class AddedExpenseTypeToItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpenseTypeId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemTypeId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ExpenseTypeId",
                table: "Items",
                column: "ExpenseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ExpenseTypes_ExpenseTypeId",
                table: "Items",
                column: "ExpenseTypeId",
                principalTable: "ExpenseTypes",
                principalColumn: "ExpenseTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ExpenseTypes_ExpenseTypeId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ExpenseTypeId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ExpenseTypeId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemTypeId",
                table: "Items");
        }
    }
}
