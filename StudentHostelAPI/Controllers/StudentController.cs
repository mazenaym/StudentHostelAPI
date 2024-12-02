using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentHostel.BLL.Service;
using StudentHostel.BLL.Service.IService;
using StudentHostel.DAL.Entites;

namespace StudentHostelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }   // GET: api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var students = _studentService.GetAllStudents();
            return Ok(students);
        }

        // GET: api/students/{id}
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound(new { message = $"Student with ID {id} not found." });
            }
            return Ok(student);
        }

        // POST: api/students
        [HttpPost]
        public IActionResult AddStudent([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest(new { message = "Invalid student data." });
            }

            _studentService.AddStudent(student);
            return CreatedAtAction(nameof(GetStudentById), new { id = student.Student_Id }, student);
        }

        // PUT: api/students/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] Student student)
        {
            if (id != student.Student_Id)
            {
                return BadRequest(new { message = "Student ID mismatch." });
            }

            var existingStudent = _studentService.GetStudentById(id);
            if (existingStudent == null)
            {
                return NotFound(new { message = $"Student with ID {id} not found." });
            }

            _studentService.UpdateStudent(student);
            return NoContent();
        }

        // DELETE: api/students/{id

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var existingStudent = _studentService.GetStudentById(id);
            if (existingStudent == null)
            {
                return NotFound(new { message = $"Student with ID {id} not found." });
            }

            _studentService.DeleteStudent(id);
            return NoContent();
        }
    }
}


