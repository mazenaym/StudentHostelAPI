using StudentHostel.DAL.Entites;

namespace StudentHostel.DAL.Repository.IRepository
{
    public interface IOwnerRepository
    {
        void AddOwner(Owner owner);
        void DeleteOwner(int id);
        IEnumerable<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        void UpdateOwner(Owner owner);
    }
}