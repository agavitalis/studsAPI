using StudentApp22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp22.Infra.Interface
{
   public interface StudentInterface
    {
       public Task<IEnumerable<Student>> GetStudent();
       public Task<Student> GetStudent(Guid id);
        public Task PutStudent(Guid id, Student student);
        public Task<Student> PostStudent(Student student);
        public Task DeleteStudent(Guid id);
        public bool StudentExists(Guid id);

    }
}
