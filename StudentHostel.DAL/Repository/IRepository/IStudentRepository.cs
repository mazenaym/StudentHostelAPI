using StudentHostel.DAL.Entites;

namespace StudentHostel.DAL.Repository.IRepository
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        void DeleteStudent(int id);
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        void UpdateStudent(Student student);
    }
}