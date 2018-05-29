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
        public string DepartureAddress { get; set; }
        public string DepartureSuburb { get; set; }
        [Required]
        public string DepartureCity { get; set; }
        [Required]
        public string DepartureRegion { get; set; }
        public string DeparturePostcode { get; set; }
        [Required]
        public string DepartureCountry { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        public DateTime DepartureTime { get; set; }
        [Required]
        public DateTime ArrivalDate { get; set; }
        public DateTime ArrivalTime { get; set; }
        [Required]
        public string ArrivalAddress { get; set; }
        public string ArrivalSuburb { get; set; }
        [Required]
        public string ArrivalCity { get; set; }
        [Required]
        public string ArrivalRegion { get; set; }
        public string ArrivalPostcode { get; set; }
        [Required]
        public string ArrivalCountry { get; set; }
        public int TripId { get; set; }
    }
}
