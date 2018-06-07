using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSEDFinalProjectTripPlanner.Models;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class TodoDTO
    {
        public MyTodo MyTodos { get; set; }
        public List<Item> AllItems { get; set; }
    }
}
