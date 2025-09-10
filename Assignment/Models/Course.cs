using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    
    internal class Course
    {
        
        public int Id { get; set; }
       
        public string? Name { get; set; }

        public string? Duration { get; set; }
        
        public string? Description { get; set; }
        
        public int top_id { get; set; }




    }
}
