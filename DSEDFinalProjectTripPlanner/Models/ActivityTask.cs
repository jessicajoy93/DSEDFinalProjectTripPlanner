using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.Models
{
    public class ActivityTask
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string TypeOfActivity { get; set; }
        public string ConfirmationNumber { get; set; }
        public string SupplierName { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime EndTime { get; set; }
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
        public int NumOfPeopleAttending { get; set; }
        public int TripId { get; set; }
    }
}
