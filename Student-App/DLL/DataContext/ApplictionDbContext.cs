using Microsoft.EntityFrameworkCore;

namespace DLL.DataContext
{
    public class ApplictionDbContext : DbContext
    {
        public ApplictionDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
