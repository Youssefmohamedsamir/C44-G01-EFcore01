using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Stud_Course
    {
        [Key]
        [Required]
        public int Stud_Id { get; set; }
        
        [Required]
        public int Course_Id { get; set; }

        public double Grade { get; set; }

    }
}
