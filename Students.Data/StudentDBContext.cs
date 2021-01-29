using Microsoft.EntityFrameworkCore;
using Students.Core.Models;
using Students.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Students.Data
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new StudentConfiguration());
        }

        internal static Task<IEnumerable<Student>> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}

