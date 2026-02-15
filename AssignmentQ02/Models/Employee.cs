using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQ02.Models
{
    internal class Employee
    {
        public int id { get; set; }
        public string? Name { get; set; }

        public string? Address { get; set; }

        public char Gender { get; set; }

        public string? Position { get; set; }

        public int BD_Year { get; set; }

        public int BD_Month { get; set; }

        public int BD_Day { get; set; }

        public int AL_id { get; set; }
    }
}
