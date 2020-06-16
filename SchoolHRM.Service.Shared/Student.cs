using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolHRM.Service.Shared
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public StudentCategory StudentCategory { get; set; }

        public Address Address { get; set; }
        
        public ParentalDetails ParentalDetails { get; set; }
    }
}
