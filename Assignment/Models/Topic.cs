using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Topic
    {
        [Key]
        [Required]
        public int Top_Id { get; set; }

        public string? Name { get; set; }

        
    }
}
