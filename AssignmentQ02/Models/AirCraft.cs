using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQ02.Models
{
    internal class AirCraft
    {
        public int Id { get; set; }

        public int Capacity { get; set; }

        public string? Model { get; set; }

        public string? Maj_pilot { get; set; }

        public string? Assistant { get; set; }

        public int Host1 { get; set; }
        public int Host2 { get; set; }
        public int AL_id  { get; set; }
    }
}
