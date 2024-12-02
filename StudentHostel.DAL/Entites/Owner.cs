using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHostel.DAL.Entites
{
    public class Owner
    {
        [Key]
        public long Owner_Id { get; set; }

        public required long Owner_Phone { get; set; }
        
        [EmailAddress]
        public required string Owner_Email { get; set; }
        
        public required string Owner_FName { get; set; }
       
        public required string Owner_LName { get; set; }
        public List<Apartment>? apartments { get; set; }
    }
}
