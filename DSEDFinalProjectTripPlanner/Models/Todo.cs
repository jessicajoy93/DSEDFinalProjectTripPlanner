using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.Models
{
    public class Todo
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }


    }
}
