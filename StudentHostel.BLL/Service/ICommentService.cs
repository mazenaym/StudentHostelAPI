using StudentHostel.DAL.Entites;

namespace StudentHostel.BLL.Service
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        void DeleteComment(int id);
    }
}