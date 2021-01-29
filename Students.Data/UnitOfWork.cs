using Students.Core;
using Students.Core.Repositories;
using Students.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly StudentDbContext _context;
        private StudentRepository _studentRepository;
        
        public UnitOfWork(StudentDbContext context)
        {
            _context = context;
        }

        public IStudentRepository Students => _studentRepository = _studentRepository ?? new StudentRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
