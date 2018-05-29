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
        public string Address { get; set; }
        public string Suburb { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Region { get; set; }
        public string Postcode { get; set; }
        [Required]
        public string Country { get; set; }
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
