using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Instructor
    {
        [Key]
        [Required]
        public int Ins_Id { get; set; }
        [Length(3, 80)]
        public string? Name { get; set; }
        [MaxLength(300 , ErrorMessage ="Max Character is 300 chars")]
        public string? Address { get; set; }
        [Required]
        public int Bouns { get; set; }
        [Required]
        public decimal Salary { get; set; }
        public double Hour_Rate { get; set; }
        [Required]
        public int Dept_id { get; set; }







    }
}
