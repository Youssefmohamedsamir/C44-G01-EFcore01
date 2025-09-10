using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Department
    {
        [Key]
        [Required]
        public int Dep_Id{ get; set; }
        [MaxLength(50 , ErrorMessage ="Name Cant Be More Than 50 chras")]
        public string? Name { get; set; }

        public DateTime Hiring_date { get; set; }
        [Required]
        public int ins_id { get; set; }



    }
}
