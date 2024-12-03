using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentHostel.BLL.Service.IService;
using StudentHostel.DAL.Entites;

namespace StudentHostelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private readonly IApartmentService _apartmentService;
        public ApartmentController(IApartmentService apartmentService)
        {
             _apartmentService = apartmentService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllApartments()
        {
            var apartments = _apartmentService.GetAllApartment();
            return Ok(apartments);
        }
        [HttpGet("{id}")]
        public IActionResult GetApartmentById(int id)
        {
            var apartment = _apartmentService.GetApartmentById(id);
            if (apartment == null)
            {
                return NotFound(new { message = $"Apartment with ID {id} not found." });
            }
            return Ok(apartment);
        }
        [HttpPost]
        public IActionResult AddApartment([FromBody] Apartment apartment)
        {
            if (apartment == null)
            {
                return BadRequest(new { message = "Invalid student data." });
            }
            _apartmentService.AddApartment(apartment);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateApartment(int id, [FromBody] Apartment apartment)
        {
            if (id != apartment.Apartment_Id)
            {
                return BadRequest(new { message = "Apartment ID mismatch." });
            }
            var existingApartment = _apartmentService.GetApartmentById(id);
            if (existingApartment == null)
            {
                return NotFound(new { message = $"Apartment with ID {id} not found." });
            }
            _apartmentService.UpdateApartment(existingApartment);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteApartment(int id)
        {
            var existingApartment = _apartmentService.GetApartmentById(id);
            if (existingApartment == null)
            {
                return NotFound(new { message = $"Apartment with ID {id} not found." });
            }
            _apartmentService.DeleteApartment(id);
            return NoContent();
        }



    }
}
