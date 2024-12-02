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
    public class ApartmentRepository : IApartmentRepository
    {
        private readonly ApplicationDbContext _context;
        public ApartmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        //add Apartment 
        public void AddApartment(Apartment apartment)
        {
            _context.apartments.Add(apartment);
            _context.SaveChanges();
        }
        // get all apartments
        public IEnumerable<Apartment> GetAllApartment()
        {
            return _context.apartments.ToList();
        }
        //GET apartment bi id
        public Apartment GetApartmentById(int id)
        {
            return _context.apartments.FirstOrDefault(a => a.Apartment_Id == id);
        }
        //update an existing apartment by id
        public void UpdateApartment(Apartment apartment)
        {
            var existingApartment = _context.apartments.Find(apartment.Apartment_Id);
            if (existingApartment != null)
            {

                existingApartment.Price = apartment.Price;
                existingApartment.IsRented = apartment.IsRented;

            }
        }
        // Delete a apartment by id
        public void DeleteApartment(int id)
        {
            var apartment = _context.apartments.Find(id);
            if (apartment != null)
            {
                _context.apartments.Remove(apartment);
                _context.SaveChanges();
            }
        }
    }
}
