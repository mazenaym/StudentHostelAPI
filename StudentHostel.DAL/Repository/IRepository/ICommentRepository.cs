using StudentHostel.DAL.Entites;

namespace StudentHostel.DAL.Repository.IRepository
{
    public interface ICommentRepository
    {
        void AddComment(Comment comment);
        void DeleteComment(int id);
        Comment GetCommentById(int id);
    }
}