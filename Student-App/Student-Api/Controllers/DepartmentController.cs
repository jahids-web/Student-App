using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Student_Api.Controllers
{
   
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("get all data");
        }
        [HttpGet("{code}")]
        public IActionResult GetA(string code)
        {
            return Ok("get a "+ code +"data");
        }
        [HttpPost]
        public IActionResult Insert()
        {
            return Ok("Insert new department");
        }
        [HttpPut("{code}")]
        public IActionResult Update (string code)
        {
            return Ok("update" +code);
        }
        [HttpDelete("{code}")]
        public IActionResult Delete(string code)
        {
            return Ok("delete" +code);
        }
    }
}
