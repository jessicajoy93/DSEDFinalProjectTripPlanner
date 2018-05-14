using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DSEDFinalProjectTripPlanner.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityTasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AddressCity = table.Column<string>(nullable: false),
                    AddressCountry = table.Column<string>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressPostcode = table.Column<string>(nullable: true),
                    AddressRegion = table.Column<string>(nullable: false),
                    ConfirmationNumber = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    LocationName = table.Column<string>(nullable: true),
                    NumOfPeopleAttending = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    SupplierName = table.Column<string>(nullable: true),
                    TypeOfActivity = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarRentals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AddressCity = table.Column<string>(nullable: false),
                    AddressCountry = table.Column<string>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressPostcode = table.Column<string>(nullable: true),
                    AddressRegion = table.Column<string>(nullable: false),
                    ConfirmationNumber = table.Column<string>(nullable: true),
                    ContactPhoneNumber = table.Column<string>(nullable: true),
                    DropoffDate = table.Column<DateTime>(nullable: false),
                    DropoffTime = table.Column<DateTime>(nullable: false),
                    PickupDate = table.Column<DateTime>(nullable: false),
                    PickupName = table.Column<string>(nullable: false),
                    PickupTime = table.Column<DateTime>(nullable: false),
                    SuppplierName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarRentals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Airline = table.Column<string>(nullable: false),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    ArrivalGate = table.Column<string>(nullable: true),
                    ArrivalTerminal = table.Column<string>(nullable: true),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    ArrivalTo = table.Column<string>(nullable: false),
                    ConfirmationNumber = table.Column<string>(nullable: true),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    DepartureFrom = table.Column<string>(nullable: false),
                    DepartureGate = table.Column<string>(nullable: true),
                    DepartureTerminal = table.Column<string>(nullable: true),
                    DepartureTime = table.Column<DateTime>(nullable: false),
                    FlightNumber = table.Column<string>(nullable: false),
                    Seats = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lodgings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AddressCity = table.Column<string>(nullable: false),
                    AddressCountry = table.Column<string>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressPostcode = table.Column<string>(nullable: true),
                    AddressRegion = table.Column<string>(nullable: false),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    ConfirmationNumber = table.Column<string>(nullable: true),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    DepartureTime = table.Column<DateTime>(nullable: false),
                    LodgingName = table.Column<string>(nullable: true),
                    NumOfGuests = table.Column<int>(nullable: false),
                    NumOfRooms = table.Column<int>(nullable: false),
                    RoomDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lodgings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtherTransportations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArrivalAddressCity = table.Column<string>(nullable: false),
                    ArrivalAddressCountry = table.Column<string>(nullable: false),
                    ArrivalAddressLine1 = table.Column<string>(nullable: false),
                    ArrivalAddressLine2 = table.Column<string>(nullable: true),
                    ArrivalAddressPostcode = table.Column<string>(nullable: true),
                    ArrivalAddressRegion = table.Column<string>(nullable: false),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    CarrierName = table.Column<string>(nullable: true),
                    DepartureAddressCity = table.Column<string>(nullable: false),
                    DepartureAddressCountry = table.Column<string>(nullable: false),
                    DepartureAddressLine1 = table.Column<string>(nullable: false),
                    DepartureAddressLine2 = table.Column<string>(nullable: true),
                    DepartureAddressPostcode = table.Column<string>(nullable: true),
                    DepartureAddressRegion = table.Column<string>(nullable: false),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    DepartureTime = table.Column<DateTime>(nullable: false),
                    TypeOfTransport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherTransportations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AddressCity = table.Column<string>(nullable: false),
                    AddressCountry = table.Column<string>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressPostcode = table.Column<string>(nullable: true),
                    AddressRegion = table.Column<string>(nullable: false),
                    ConfirmationNumber = table.Column<string>(nullable: true),
                    Cuisine = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DressCode = table.Column<string>(nullable: true),
                    HoursOfOperation = table.Column<string>(nullable: true),
                    NumberInParty = table.Column<int>(nullable: false),
                    PriceRange = table.Column<string>(nullable: true),
                    RestaurantName = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Travellers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    FrequentFlyerNumber = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travellers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DestinationCity = table.Column<string>(nullable: true),
                    DestinationCountry = table.Column<string>(nullable: true),
                    FinishDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityTasks");

            migrationBuilder.DropTable(
                name: "CarRentals");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Lodgings");

            migrationBuilder.DropTable(
                name: "OtherTransportations");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Travellers");

            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
