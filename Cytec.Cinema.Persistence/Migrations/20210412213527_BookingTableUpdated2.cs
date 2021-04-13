using Microsoft.EntityFrameworkCore.Migrations;

namespace Cytec.Cinema.Persistence.Migrations
{
    public partial class BookingTableUpdated2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "decimal(2,2)",
                table: "Movies",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "decimal(8,2)",
                table: "Bookings",
                newName: "Amount");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Movies",
                type: "decimal(2,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Bookings",
                type: "decimal(8,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Movies",
                newName: "decimal(2,2)");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Bookings",
                newName: "decimal(8,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "decimal(2,2)",
                table: "Movies",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "decimal(8,2)",
                table: "Bookings",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)");
        }
    }
}
