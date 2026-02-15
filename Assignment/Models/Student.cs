using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    [Table("StudentsTable")]
    internal class Student
    {
        [Key]
        public int Stu_Id { get; set; }
        [Column("Student_First_Name" , TypeName = "varchar")]
        public string? FName { get; set; }
        
        [MaxLength(50, ErrorMessage = "Name Cannot Exceed 50 Chars")]
        [MinLength(3, ErrorMessage = "Name Cannot Exeed Less 3 Chars")]
        
        public string? LName { get; set; }
        [Required]
        [Range(22,40)]
        public int Age { get; set; }
        [MaxLength(300 , ErrorMessage ="Max Length Character is 300")]
        public string? Address { get; set; }
        [Required]
        public int Dep_Id { get; set; }

        





    }
}
