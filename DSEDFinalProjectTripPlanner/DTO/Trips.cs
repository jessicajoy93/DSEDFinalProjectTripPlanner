using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class Trips
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationCountry { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Description { get; set; }
    }
}
