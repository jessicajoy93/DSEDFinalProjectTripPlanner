using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DSEDFinalProjectTripPlanner.Migrations
{
    public partial class car : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Door",
                table: "CarRentals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LargeBag",
                table: "CarRentals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Litres",
                table: "CarRentals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Seats",
                table: "CarRentals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SmallBag",
                table: "CarRentals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Transmission",
                table: "CarRentals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Door",
                table: "CarRentals");

            migrationBuilder.DropColumn(
                name: "LargeBag",
                table: "CarRentals");

            migrationBuilder.DropColumn(
                name: "Litres",
                table: "CarRentals");

            migrationBuilder.DropColumn(
                name: "Seats",
                table: "CarRentals");

            migrationBuilder.DropColumn(
                name: "SmallBag",
                table: "CarRentals");

            migrationBuilder.DropColumn(
                name: "Transmission",
                table: "CarRentals");
        }
    }
}
