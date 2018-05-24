using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.Models
{
    public class OtherTransportation
    {
        public int Id { get; set; }
        public string TypeOfTransport { get; set; }
        public string CarrierName { get; set; }
        [Required]
        public string DepartureAddressLine1 { get; set; }
        public string DepartureAddressLine2 { get; set; }
        [Required]
        public string DepartureAddressCity { get; set; }
        [Required]
        public string DepartureAddressRegion { get; set; }
        public string DepartureAddressPostcode { get; set; }
        [Required]
        public string DepartureAddressCountry { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        public DateTime DepartureTime { get; set; }
        [Required]
        public DateTime ArrivalDate { get; set; }
        public DateTime ArrivalTime { get; set; }
        [Required]
        public string ArrivalAddressLine1 { get; set; }
        public string ArrivalAddressLine2 { get; set; }
        [Required]
        public string ArrivalAddressCity { get; set; }
        [Required]
        public string ArrivalAddressRegion { get; set; }
        public string ArrivalAddressPostcode { get; set; }
        [Required]
        public string ArrivalAddressCountry { get; set; }
        public int TripId { get; set; }
    }
}
