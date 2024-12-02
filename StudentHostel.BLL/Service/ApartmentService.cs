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
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRepository _apartmentrepository;
        public ApartmentService(IApartmentRepository apartmentRepository)
        {
            _apartmentrepository = apartmentRepository;
        }
        public void AddApartment(Apartment apartment)
        {
            _apartmentrepository.AddApartment(apartment);
        }
        public IEnumerable<Apartment> GetAllApartment()
        {
            return _apartmentrepository.GetAllApartment();
        }
        public Apartment GetApartmentById(int id)
        {
            return _apartmentrepository.GetApartmentById(id);
        }
        public void UpdateApartment(Apartment apartment)
        {
            _apartmentrepository.UpdateApartment(apartment);
        }
        public void DeleteApartment(int id)
        {
            _apartmentrepository.DeleteApartment(id);
        }
    }
}
