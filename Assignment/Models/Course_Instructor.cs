using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Course_Instructor
    {
        [Key]
        [Required]
        public int Course_Id { get; set; }
       
        [Required]
        public int Inst_Id { get; set; }
        [MinLength(100)]
        public string? Evalution { get; set; }



    }
}
