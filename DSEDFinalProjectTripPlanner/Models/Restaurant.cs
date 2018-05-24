using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.Models
{
    public class Restaurant
    {
        [Required]
        public int Id { get; set; }
        public string RestaurantName { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required]
        public string AddressCity { get; set; }
        [Required]
        public string AddressRegion { get; set; }
        public string AddressPostcode { get; set; }
        [Required]
        public string AddressCountry { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime Time { get; set; }
        public string Cuisine { get; set; }
        public int NumberInParty { get; set; }
        public string ConfirmationNumber { get; set; }
        public string HoursOfOperation { get; set; }
        public string DressCode { get; set; }
        public string PriceRange { get; set; }
        public int TripId { get; set; }
    }
}
