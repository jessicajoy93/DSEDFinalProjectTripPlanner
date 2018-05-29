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
        public string PickupAddress { get; set; }
        public string PickupSuburb { get; set; }
        [Required]
        public string PickupCity { get; set; }
        [Required]
        public string PickupRegion { get; set; }
        public string PickupPostcode { get; set; }
        [Required]
        public string PickupCountry { get; set; }
        public string DropoffAddress { get; set; }
        public string DropoffSuburb { get; set; }
        public string DropoffCity { get; set; }
        public string DropoffRegion { get; set; }
        public string DropoffPostcode { get; set; }
        public string DropoffCountry { get; set; }
        [Required]
        public DateTime PickupDate { get; set; }
        public DateTime PickupTime { get; set; }
        [Required]
        public DateTime DropoffDate { get; set; }
        public DateTime DropoffTime { get; set; }
        [Phone]
        public string SupplierContactPhoneNumber { get; set; }
        public int TripId { get; set; }
    }
}
