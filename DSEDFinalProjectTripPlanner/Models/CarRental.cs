using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.Models
{
    public class CarRental
    {
        [Required]
        public int Id { get; set; }
        public string SuppplierName { get; set; }
        public string ConfirmationNumber { get; set; }
        [Required]
        public string PickupName { get; set; }
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
        [Required]
        public DateTime PickupDate { get; set; }
        public DateTime PickupTime { get; set; }
        [Required]
        public DateTime DropoffDate { get; set; }
        public DateTime DropoffTime { get; set; }
        [Phone]
        public string ContactPhoneNumber { get; set; }
        public int TripId { get; set; }
    }
}
