using Students.Core.Models;
using Students.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Data.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository 
    {
        public StudentRepository(StudentDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await StudentDbContext
                .ToListAsync();
        }

        public Task<Student> GetStudentByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        private StudentDbContext studentDbContext
        {
            get { return Context as StudentDbContext; }
        }
    }
}
