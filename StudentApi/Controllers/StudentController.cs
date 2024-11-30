using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;
using StudentApi.Services;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet(Name = "GetAllStudents")]
        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await studentService.GetAllStudentsAsync();
        }
    }
}
