using DLL.DataContext;
using DLL.Model;

namespace DLL.Repositories
{
    public interface IStudentRepository:IRepositoryBase<Student>
    {
       
    }
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(ApplictionDbContext context) : base(context)
        {
        }
    }
}
