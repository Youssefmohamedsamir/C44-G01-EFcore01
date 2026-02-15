using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQ02.Models
{
    internal class Aircraft_Routes
    {
        public int Id { get; set; }
        public int Route_Id { get; set; }
        public int Departure { get; set; }
        public int Num_Of_Pass { get; set; }
        public double Price { get; set; }

        public string? Arrival { get; set; }
    }
}
