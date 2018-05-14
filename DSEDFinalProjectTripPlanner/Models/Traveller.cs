using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.Models
{
    public class Traveller
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Phone]
        public string Email { get; set; }
        [EmailAddress]
        public string PhoneNumber { get; set; }
        public string FrequentFlyerNumber { get; set; }
    }
}
