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
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _ownerRepository;
        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }
        public void AddOwner(Owner owner)
        {
            _ownerRepository.AddOwner(owner);
        }
        public IEnumerable<Owner> GetAllOwners()
        {
            return _ownerRepository.GetAllOwners();
        }
        public Owner GetOwnerById(int id)
        {
            return _ownerRepository.GetOwnerById(id);
        }
        public void UpdateOwner(Owner owner)
        {
            _ownerRepository.UpdateOwner(owner);
        }
        public void DeleteOwner(int id)
        {
            _ownerRepository.DeleteOwner(id);
        }
    }
}
