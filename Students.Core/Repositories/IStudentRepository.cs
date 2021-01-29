using System.Collections.Generic;
using System.Threading.Tasks;
using Students.Core.Models;

namespace Students.Core.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByIdAsync(int Id);
        
    }
}
