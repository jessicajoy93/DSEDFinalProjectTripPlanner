using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DSEDFinalProjectTripPlanner.Migrations
{
    public partial class trip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityTasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    ConfirmationNumber = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    NumOfPeopleAttending = table.Column<int>(nullable: false),
                    Postcode = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Suburb = table.Column<string>(nullable: true),
                    SupplierName = table.Column<string>(nullable: true),
                    TripId = table.Column<int>(nullable: false),
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
                    ConfirmationNumber = table.Column<string>(nullable: true),
                    DropoffAddress = table.Column<string>(nullable: true),
                    DropoffCheckbox = table.Column<bool>(nullable: false),
                    DropoffCity = table.Column<string>(nullable: true),
                    DropoffCountry = table.Column<string>(nullable: true),
                    DropoffDate = table.Column<DateTime>(nullable: false),
                    DropoffPostcode = table.Column<string>(nullable: true),
                    DropoffRegion = table.Column<string>(nullable: true),
                    DropoffSuburb = table.Column<string>(nullable: true),
                    DropoffTime = table.Column<DateTime>(nullable: false),
                    PickupAddress = table.Column<string>(nullable: false),
                    PickupCity = table.Column<string>(nullable: false),
                    PickupCountry = table.Column<string>(nullable: false),
                    PickupDate = table.Column<DateTime>(nullable: false),
                    PickupName = table.Column<string>(nullable: false),
                    PickupPostcode = table.Column<string>(nullable: true),
                    PickupRegion = table.Column<string>(nullable: false),
                    PickupSuburb = table.Column<string>(nullable: true),
                    PickupTime = table.Column<DateTime>(nullable: false),
                    SupplierPhoneNumber = table.Column<string>(nullable: true),
                    SuppplierName = table.Column<string>(nullable: false),
                    TripId = table.Column<int>(nullable: false)
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
                    Seats = table.Column<string>(nullable: true),
                    TripId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Human",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActivityTaskId = table.Column<int>(nullable: false),
                    CarRentalId = table.Column<int>(nullable: false),
                    FlightId = table.Column<int>(nullable: false),
                    FrequentFlyerNumber = table.Column<string>(nullable: true),
                    Fullname = table.Column<string>(nullable: true),
                    LodgingId = table.Column<int>(nullable: false),
                    OtherTransportationId = table.Column<int>(nullable: false),
                    RestaurantId = table.Column<int>(nullable: false),
                    TicketNumber = table.Column<string>(nullable: true),
                    TripId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Human", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lodgings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(nullable: false),
                    AddressCity = table.Column<string>(nullable: false),
                    AddressCountry = table.Column<string>(nullable: false),
                    AddressPostcode = table.Column<string>(nullable: true),
                    AddressRegion = table.Column<string>(nullable: false),
                    AddressSuburb = table.Column<string>(nullable: false),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    ConfirmationNumber = table.Column<string>(nullable: true),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    DepartureTime = table.Column<DateTime>(nullable: false),
                    LodgingName = table.Column<string>(nullable: false),
                    NumOfGuests = table.Column<int>(nullable: false),
                    NumOfRooms = table.Column<int>(nullable: false),
                    RoomDescription = table.Column<string>(nullable: true),
                    TripId = table.Column<int>(nullable: false)
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
                    ArrivalAddress = table.Column<string>(nullable: false),
                    ArrivalCity = table.Column<string>(nullable: false),
                    ArrivalCountry = table.Column<string>(nullable: false),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    ArrivalPostcode = table.Column<string>(nullable: true),
                    ArrivalRegion = table.Column<string>(nullable: false),
                    ArrivalSuburb = table.Column<string>(nullable: true),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    CarrierName = table.Column<string>(nullable: true),
                    ConfirmationNumber = table.Column<string>(nullable: true),
                    DepartureAddress = table.Column<string>(nullable: false),
                    DepartureCity = table.Column<string>(nullable: false),
                    DepartureCountry = table.Column<string>(nullable: false),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    DeparturePostcode = table.Column<string>(nullable: true),
                    DepartureRegion = table.Column<string>(nullable: false),
                    DepartureSuburb = table.Column<string>(nullable: true),
                    DepartureTime = table.Column<DateTime>(nullable: false),
                    TripId = table.Column<int>(nullable: false),
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
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    ConfirmationNumber = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: false),
                    Cuisine = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DressCode = table.Column<string>(nullable: true),
                    HoursOfOperation = table.Column<string>(nullable: true),
                    NumberInParty = table.Column<int>(nullable: false),
                    Postcode = table.Column<string>(nullable: true),
                    PriceRange = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: false),
                    RestaurantName = table.Column<string>(nullable: false),
                    Suburb = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    TripId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    DestinationCity = table.Column<string>(nullable: false),
                    DestinationCountry = table.Column<string>(nullable: false),
                    FinishDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
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
                name: "Human");

            migrationBuilder.DropTable(
                name: "Lodgings");

            migrationBuilder.DropTable(
                name: "OtherTransportations");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
