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
    public class OwnerRepository :IOwnerRepository
    {
        private readonly ApplicationDbContext _context;
        public OwnerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddOwner(Owner owner)
        {
            _context.owners.Add(owner);
            _context.SaveChanges();
        }
        //get all owners 
        public IEnumerable<Owner> GetAllOwners()
        {
            return _context.owners.ToList();
        }
        // get owner by id
        public Owner GetOwnerById(int id)
        {
            return _context.owners.FirstOrDefault(o => o.Owner_Id == id);

        }
        //update owner 
        public void UpdateOwner(Owner owner)
        {
            var existingOwner = _context.owners.Find(owner.Owner_Id);
            if (existingOwner != null)
            {

                existingOwner.Owner_Email = owner.Owner_Email;
                existingOwner.Owner_Phone = owner.Owner_Phone;
                existingOwner.Owner_FName = owner.Owner_FName;
                existingOwner.Owner_LName = owner.Owner_LName;
                _context.SaveChanges();
            }
        }
        // Delete a owner by ssn
        public void DeleteOwner(int id)
        {
            var owner = _context.owners.Find(id);
            if (owner != null)
            {
                _context.owners.Remove(owner);
                _context.SaveChanges();
            }
        }
    }
}
