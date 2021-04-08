using Microsoft.EntityFrameworkCore.Migrations;

namespace CredeitCardWebAPI.Migrations
{
    public partial class DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CreditLimit",
                table: "CardDetails",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "AnnualCharge",
                table: "CardDetails",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_CardDetails_CardTypeId",
                table: "CardDetails",
                column: "CardTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardDetails_CardMasterTypes_CardTypeId",
                table: "CardDetails",
                column: "CardTypeId",
                principalTable: "CardMasterTypes",
                principalColumn: "CardTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardDetails_CardMasterTypes_CardTypeId",
                table: "CardDetails");

            migrationBuilder.DropIndex(
                name: "IX_CardDetails_CardTypeId",
                table: "CardDetails");

            migrationBuilder.AlterColumn<decimal>(
                name: "CreditLimit",
                table: "CardDetails",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "AnnualCharge",
                table: "CardDetails",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
