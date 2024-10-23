using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pratik_DependencyInjection.Teacher;

namespace Pratik_DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public TeacherController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _teacher.GetTeacherInfo();
            return Ok();
        }
    }
}
