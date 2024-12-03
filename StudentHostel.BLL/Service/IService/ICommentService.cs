using StudentHostel.DAL.Entites;

namespace StudentHostel.BLL.Service.IService
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        void DeleteComment(int id);
        Comment GetCommentById(int id);
    }
}