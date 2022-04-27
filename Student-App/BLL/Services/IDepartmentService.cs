using DLL.Model;
using DLL.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAllAsync();
        Task<Department> GetAAsync(string code);
        Task<Department> InsertAsync(Department departmen);
        Task<Department> UpdateAsync(string code, Department department);
        Task<Department> DeleteAsync(string code);
    }
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<Department> InsertAsync(Department departmen)
        {
            return await _departmentRepository.InsertAsync(departmen);
        }
      
        public async Task<Department> GetAAsync(string code)
        {
            return await _departmentRepository.GetAAsync(code);
        }

        public async Task<List<Department>> GetAllAsync()
        {
            return await _departmentRepository.GetAllAsync();
        }
        public async Task<Department> UpdateAsync(string code, Department department)
        {
            return await _departmentRepository.UpdateAsync(code, department);
        }
        public async Task<Department> DeleteAsync(string code)
        {
            return await _departmentRepository.DeleteAsync(code);
        }
    }
}
