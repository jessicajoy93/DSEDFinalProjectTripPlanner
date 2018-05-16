using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.Models
{
    public class Trip
    {
        public Trip()
        {
        }

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string DestinationCity { get; set; }
        [Required]
        public string DestinationCountry { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime FinishDate { get; set; }

        public int TotalDaysAway { get; set; } //to be removed at later date
        public string Description { get; set; }
    }
}
