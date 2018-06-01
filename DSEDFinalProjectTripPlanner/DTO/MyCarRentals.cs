using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class MyCarRentals
    {
        public int Id { get; set; }
        public string SuppplierName { get; set; }
        public string ConfirmationNumber { get; set; }
        public string PickupName { get; set; }
        public string PickupAddress { get; set; }
        public string PickupSuburb { get; set; }
        public string PickupCity { get; set; }
        public string PickupRegion { get; set; }
        public string PickupPostcode { get; set; }
        public string PickupCountry { get; set; }
        public string DropoffAddress { get; set; }
        public string DropoffSuburb { get; set; }
        public string DropoffCity { get; set; }
        public string DropoffRegion { get; set; }
        public string DropoffPostcode { get; set; }
        public string DropoffCountry { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime PickupTime { get; set; }
        public DateTime DropoffDate { get; set; }
        public DateTime DropoffTime { get; set; }
        public string SupplierPhoneNumber { get; set; }
        public int TripId { get; set; }
        public bool DropoffCheckbox { get; set; }
        public int Door { get; set; }
        public int Seats { get; set; }
        public string Transmission { get; set; }
        public int LargeBag { get; set; }
        public int SmallBag { get; set; }
        public int Litres { get; set; }
    }
}
