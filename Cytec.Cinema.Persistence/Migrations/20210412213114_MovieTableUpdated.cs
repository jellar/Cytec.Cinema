using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cytec.Cinema.Persistence.Migrations
{
    public partial class MovieTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Shows",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Shows",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Shows",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Shows",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Screens",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Screens",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Screens",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Screens",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Movies",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Movies",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Bookings",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Bookings",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Bookings",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Bookings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tickets",
                table: "Bookings",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Screens");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Screens");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Screens");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Screens");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Tickets",
                table: "Bookings");
        }
    }
}
