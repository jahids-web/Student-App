using BLL.Services;
using DLL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Student_Api.Controllers
{
    public class StudentController : MainController
    {
        private readonly IStudentService _studentRepository;

        public StudentController(IStudentService studentService)
        {
            _studentRepository = studentService;
        }
        [HttpPost]
        public async Task<IActionResult> InsertAsync(Student student)
        {
            return Ok(await _studentRepository.InsertAsync(student));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
           return Ok(await _studentRepository.GetAllAsync()); 
        }
        [HttpGet("{email}")]
        public async Task<IActionResult> GetAAsync(string email)
        {
            return Ok(await _studentRepository.GetAAsync(email));
        }
    
        [HttpPut("{email}")]
        public async Task<IActionResult> UpdateAsync(string email,Student student)
        {
            return Ok(await _studentRepository.UpdateAsync(email,student));
        }
        [HttpDelete("{email}")]
        public async Task<IActionResult> DeleteAsync(string email)
        {
            return Ok(await _studentRepository.DeleteAsync(email));
        }
    }
}
