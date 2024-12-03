using Microsoft.EntityFrameworkCore;
using StudentHostel.BLL.Service.IService;
using StudentHostel.DAL.Entites;
using StudentHostel.DAL.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHostel.BLL.Service
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public void AddComment(Comment comment)
        {
            _commentRepository.AddComment(comment);
        }
        public void DeleteComment(int id)
        {
            _commentRepository.DeleteComment(id);
        }
        public Comment GetCommentById(int id)
        {
            return _commentRepository.GetCommentById(id);
        }
    }
}
