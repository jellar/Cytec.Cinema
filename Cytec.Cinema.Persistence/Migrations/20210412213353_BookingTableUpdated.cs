using Microsoft.EntityFrameworkCore.Migrations;

namespace Cytec.Cinema.Persistence.Migrations
{
    public partial class BookingTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Movies",
                newName: "decimal(2,2)");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Bookings",
                newName: "decimal(8,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "decimal(2,2)",
                table: "Movies",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "decimal(8,2)",
                table: "Bookings",
                newName: "Amount");
        }
    }
}
