using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Student_Api.Controllers
{
    
   
    public class StudentController : MainController
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("get all data");
        }
        [HttpGet("{email}")]
        public IActionResult GetA(string email)
        {
            return Ok("get a " + email + "data");
        }
        [HttpPost]
        public IActionResult Insert()
        {
            return Ok("Insert new email");
        }
        [HttpPut("{email}")]
        public IActionResult Update(string email)
        {
            return Ok("update" + email);
        }
        [HttpDelete("{email}")]
        public IActionResult Delete(string email)
        {
            return Ok("delete" + email);
        }
    }
}
