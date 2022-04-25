using DLL.Model;
using Microsoft.EntityFrameworkCore;

namespace DLL.DataContext
{
    public class ApplictionDbContext : DbContext
    {
        public ApplictionDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
