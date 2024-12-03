using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentHostel.BLL.Service;
using StudentHostel.BLL.Service.IService;
using StudentHostel.DAL.Entites;

namespace StudentHostelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpPost]
        public IActionResult AddComment([FromBody] Comment comment)
        {
            if (comment == null)
            {
                return BadRequest(new { message = "invalid comment data" });
            }
            _commentService.AddComment(comment);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteComment(int id, [FromBody] Comment comment)
        {
            var existingComment = _commentService.GetCommentById(id);
            if (existingComment == null)
            {
                return NotFound(new { message = $"Comment with ID {id} not found." });
            }
            _commentService.DeleteComment(id);
            return NoContent();
        }
    }
}
