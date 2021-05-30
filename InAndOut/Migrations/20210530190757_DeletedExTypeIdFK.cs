using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class DeletedExTypeIdFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExTypeId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_ExTypeId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ExTypeId",
                table: "Expenses");

            migrationBuilder.AddColumn<int>(
                name: "ExpenseTypeId",
                table: "Expenses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseTypeId",
                table: "Expenses",
                column: "ExpenseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExpenseTypeId",
                table: "Expenses",
                column: "ExpenseTypeId",
                principalTable: "ExpenseTypes",
                principalColumn: "ExpenseTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExpenseTypeId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_ExpenseTypeId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ExpenseTypeId",
                table: "Expenses");

            migrationBuilder.AddColumn<int>(
                name: "ExTypeId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExTypeId",
                table: "Expenses",
                column: "ExTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExTypeId",
                table: "Expenses",
                column: "ExTypeId",
                principalTable: "ExpenseTypes",
                principalColumn: "ExpenseTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
