using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DSEDFinalProjectTripPlanner.Migrations
{
    public partial class human : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FrequentFlyerNumber",
                table: "Travellers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TicketNumber",
                table: "Travellers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FrequentFlyerNumber",
                table: "Travellers");

            migrationBuilder.DropColumn(
                name: "TicketNumber",
                table: "Travellers");
        }
    }
}
