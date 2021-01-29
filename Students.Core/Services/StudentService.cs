using System.Threading.Tasks;
using Students.Core.Models;

namespace Students.Core.Services
{
    public interface StudentService
    {

        Task<Student> GetStudentById(int id);
        Task<Student> CreateMusic(Student NewStudent);
        Task UpdateMusic(Student StudentUpdate, Student Student);
        Task DeleteMusic(Student Student);
    }
}
