using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.Models
{
    public class Human
    {
        [Required]
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string FrequentFlyerNumber { get; set; }
        public string TicketNumber { get; set; }
        public int TripId { get; set; }
        public int FlightId { get; set; }
        public int LodgingId { get; set; }
        public int OtherTransportationId { get; set; }
        public int RestaurantId { get; set; }
        public int CarRentalId { get; set; }
        public int ActivityTaskId { get; set; }
    }
}
