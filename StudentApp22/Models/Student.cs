using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp22.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string StudentName{ get; set; }
        public string StudentAddress { get; set; }

        public List<Course> Courses { get; set; }
    }
}
