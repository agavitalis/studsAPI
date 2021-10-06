using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentApp22.Models;

namespace StudentApp22.Data
{
    public class StudentApp22Context : DbContext
    {
        public StudentApp22Context (DbContextOptions<StudentApp22Context> options)
            : base(options)
        {
        }

        public DbSet<StudentApp22.Models.Student> Student { get; set; }

        public DbSet<StudentApp22.Models.Course> Course { get; set; }
    }
}
