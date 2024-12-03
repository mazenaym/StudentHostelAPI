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
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _context;
        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        //add comment
        public void AddComment(Comment comment)
        {
            _context.comments.Add(comment);
            _context.SaveChanges();
        }
        //delete commentt 
        // Delete a comment by ID
        public void DeleteComment(int id)
        {
            var comment = _context.comments.Find(id);
            if (comment != null)
            {
                _context.comments.Remove(comment);
                _context.SaveChanges();
            }
        }
        public Comment GetCommentById(int id)
        {
            return _context.comments.FirstOrDefault(o => o.Comment_ID == id);
        }


    }
}
