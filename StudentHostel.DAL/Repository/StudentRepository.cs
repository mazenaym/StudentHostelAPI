using StudentHostel.DAL.Database;
using StudentHostel.DAL.Entites;
using StudentHostel.DAL.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHostel.DAL.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddStudent(Student student)
        {
            _context.students.Add(student);
            _context.SaveChanges();
        }

        // Get all students
        public IEnumerable<Student> GetAllStudents()
        {
            return _context.students.ToList();
        }

        // Get a student by ID
        public Student GetStudentById(int id)
        {
            return _context.students.FirstOrDefault(s => s.Student_Id == id);
        }

        // Update an existing student
        public void UpdateStudent(Student student)
        {
            var existingStudent = _context.students.Find(student.Student_Id);
            if (existingStudent != null)
            {
                existingStudent.Student_Id = student.Student_Id;
                existingStudent.Student_FName = student.Student_FName;
                existingStudent.Student_LName = student.Student_LName;
                existingStudent.Student_Phone = student.Student_Phone;
                existingStudent.Student_email = student.Student_email;
                existingStudent.College = student.College;


                _context.SaveChanges();
            }
        }

        // Delete a student by ID
        public void DeleteStudent(int id)
        {
            var student = _context.students.Find(id);
            if (student != null)
            {
                _context.students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}
