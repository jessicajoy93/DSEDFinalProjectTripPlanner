﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.Models
{
    public class Lodging
    {
        [Required]
        public int Id { get; set; }
        public string ConfirmationNumber { get; set; }
        public string LodgingName { get; set; }
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
        public DateTime ArrivalDate { get; set; }
        public DateTime ArrivalTime { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        public DateTime DepartureTime { get; set; }
        public int NumOfGuests { get; set; }
        public int NumOfRooms { get; set; }
        public string RoomDescription { get; set; }
    }
}
