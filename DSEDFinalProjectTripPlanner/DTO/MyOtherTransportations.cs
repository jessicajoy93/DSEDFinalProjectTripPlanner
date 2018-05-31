using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class MyOtherTransportations
    {
        public int Id { get; set; }
        public string TypeOfTransport { get; set; }
        public string CarrierName { get; set; }
        public string ConfirmationNumber { get; set; }
        public string DepartureAddress { get; set; }
        public string DepartureSuburb { get; set; }
        public string DepartureCity { get; set; }
        public string DepartureRegion { get; set; }
        public string DeparturePostcode { get; set; }
        public string DepartureCountry { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string ArrivalAddress { get; set; }
        public string ArrivalSuburb { get; set; }
        public string ArrivalCity { get; set; }
        public string ArrivalRegion { get; set; }
        public string ArrivalPostcode { get; set; }
        public string ArrivalCountry { get; set; }
        public int TripId { get; set; }
    }
}
