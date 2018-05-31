using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class MyActivities
    {
        public int Id { get; set; }
        public string TypeOfActivity { get; set; }
        public string ConfirmationNumber { get; set; }
        public string SupplierName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime EndTime { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public int NumOfPeopleAttending { get; set; }
        public int TripId { get; set; }
    }
}
