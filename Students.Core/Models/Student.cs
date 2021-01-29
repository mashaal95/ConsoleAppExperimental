using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Core.Models
{
    public class Student
    {
        public int Id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public String Address { get; set; }

        public Int64 PhoneNum { get; set; }

        public Int32 Age { get; set; }

        [StringLength(12, ErrorMessage = "Gender should be male, female or unspecified.")]
        public String Gender { get; set; }

    }
}
