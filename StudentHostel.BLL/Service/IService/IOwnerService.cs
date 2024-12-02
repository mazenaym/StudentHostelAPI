using StudentHostel.DAL.Entites;

namespace StudentHostel.BLL.Service.IService
{
    public interface IOwnerService
    {
        void AddOwner(Owner owner);
        void DeleteOwner(int id);
        IEnumerable<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        void UpdateOwner(Owner owner);
    }
}