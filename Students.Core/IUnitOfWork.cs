using System;
using System.Threading.Tasks;
using Students.Core.Repositories;

namespace Students.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }

        Task<int> CommitAsync();
    }
}
