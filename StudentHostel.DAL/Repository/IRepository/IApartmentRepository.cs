using StudentHostel.DAL.Entites;

namespace StudentHostel.DAL.Repository.IRepository
{
    public interface IApartmentRepository
    {
        void AddApartment(Apartment apartment);
        void DeleteApartment(int id);
        IEnumerable<Apartment> GetAllApartment();
        Apartment GetApartmentById(int id);
        void UpdateApartment(Apartment apartment);
    }
}