using StudentApp22.Data;
using StudentApp22.Infra.Interface;
using StudentApp22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp22.Infra.Repository
{
    public class StudentRepository : StudentInterface
    {
        private readonly StudentApp22Context _context;

        public StudentRepository(StudentApp22Context context)
        {
            _context = context;
        }
        public async Task DeleteStudent(Guid id)
        {
            var student = await _context.Student.FindAsync(id);
            if (student != null)
            {
                _context.Student.Remove(student);
                await _context.SaveChangesAsync();
            }
        }

        public Task<IEnumerable<Student>> GetStudent()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudent(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> PostStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Task PutStudent(Guid id, Student student)
        {
            throw new NotImplementedException();
        }

        public bool StudentExists(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
