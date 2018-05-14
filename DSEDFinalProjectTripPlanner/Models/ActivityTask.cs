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
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public DateTime EndTime { get; set; }
        public string LocationName { get; set; }
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
        public int NumOfPeopleAttending { get; set; }
    }
}
