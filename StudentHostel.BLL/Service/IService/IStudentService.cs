using StudentHostel.DAL.Entites;

namespace StudentHostel.BLL.Service.IService
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        void DeleteStudent(int id);
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        void UpdateStudent(Student student);
    }
}