using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentHostel.BLL.Service.IService;
using StudentHostel.DAL.Entites;

namespace StudentHostelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;
        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService; 
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllOwners()
        { 
         var owners=_ownerService.GetAllOwners();
            return Ok(owners);
        }
        [HttpGet("{id}")]
        public IActionResult GetOwnerById(int id)
        {
            var owner = _ownerService.GetOwnerById(id);
            if (owner == null)
            {
                return NotFound(new { message = $"Owner with ID {id} not found." });
            }
            return Ok(owner);
        }
        [HttpPost]
        public IActionResult AddOwner([FromBody] Owner owner) 
        {
            if (owner == null)
            {
                return BadRequest(new { message = "Invalid student data." });
            }
            _ownerService.AddOwner(owner);
            return Ok();
          
        }
        [HttpPut("{id}")]
        public IActionResult UpdateOwner(int id ,[FromBody] Owner owner)
        { 
         if (id !=owner.Owner_Id)
            {
                return BadRequest(new { message = "Student ID mismatch." });
            }
         var existingOwner = _ownerService.GetOwnerById(id);
            if (existingOwner == null)
            {
                return NotFound(new { message = $"Owner with ID {id} not found." });
            }
            _ownerService.UpdateOwner(owner);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteOwner(int id)
        {
            var existingOwner = _ownerService.GetOwnerById(id);
            if (existingOwner == null)
            {
                return NotFound(new { message = $"Owner with ID {id} not found." });
            }
            _ownerService.DeleteOwner(id);
            return NoContent();
        }
    }
}
