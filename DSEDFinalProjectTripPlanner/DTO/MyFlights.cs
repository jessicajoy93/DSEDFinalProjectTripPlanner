using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class MyFlights
    {
        public int Id { get; set; }
        public string ConfirmationNumber { get; set; }
        public string Airline { get; set; }
        public string FlightNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime DepartureTime { get; set; }
        public string DepartureFrom { get; set; }
        public string DepartureTerminal { get; set; }
        public string DepartureGate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string ArrivalTo { get; set; }
        public string ArrivalTerminal { get; set; }
        public string ArrivalGate { get; set; }
        public string Seats { get; set; }
        public int TripId { get; set; }
    }
}
