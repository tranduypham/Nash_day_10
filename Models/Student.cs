using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day_10.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        
        [Column("FirstName", TypeName = "ntext")]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Column("LastName", TypeName = "ntext")]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Column("City", TypeName = "ntext")]
        [MaxLength(30)]
        public string City { get; set; }

        [Column("State", TypeName = "ntext")]
        [MaxLength(30)]
        public string State { get; set; }
    }
}