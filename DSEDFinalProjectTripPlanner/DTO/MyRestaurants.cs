using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class MyRestaurants
    {
        public int Id { get; set; }
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
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
