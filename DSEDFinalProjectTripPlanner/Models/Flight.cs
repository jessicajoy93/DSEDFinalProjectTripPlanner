using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DSEDFinalProjectTripPlanner.Models
{
    public class Flight
    {
        [Required]
        public int Id { get; set; }
        public string ConfirmationNumber { get; set; }
        [Required]
        public string Airline { get; set; }
        [Required]
        public string FlightNumber { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        [Required]
        public DateTime DepartureTime { get; set; }
        [Required]
        public string DepartureFrom { get; set; }
        public string DepartureTerminal { get; set; }
        public string DepartureGate { get; set; }
        [Required]
        public DateTime ArrivalDate { get; set; }
        [Required]
        public DateTime ArrivalTime { get; set; }
        [Required]
        public string ArrivalTo { get; set; }
        public string ArrivalTerminal { get; set; }
        public string ArrivalGate { get; set; }
        public string Seats { get; set; }
        [Required]
        public int TripId { get; set; }

    }
}
