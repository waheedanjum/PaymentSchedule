using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentSchedule.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CompletionFee",
                table: "Vehicel",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "FinanceTerm",
                table: "Vehicel",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletionFee",
                table: "Vehicel");

            migrationBuilder.DropColumn(
                name: "FinanceTerm",
                table: "Vehicel");
        }
    }
}
