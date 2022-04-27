using DLL.DataContext;
using DLL.Repositories;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DLL
{
    public class DLLDepandency
    {
        public static void AllDepandency(IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddDbContext<ApplictionDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DatabaseConnection")));


            //Repository dependency
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            services.AddTransient<IStudentRepository, StudentRepository>();
        }
    }
}
