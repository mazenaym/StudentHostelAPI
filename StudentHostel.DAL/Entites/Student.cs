using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHostel.DAL.Entites
{
    public class Student
    {
        [Key]
        public int Student_Id { get; set; }
       
        public long Student_Phone { get; set; }
        [EmailAddress]
        
        public required string Student_email { get; set; }

       
        public required string Student_FName { get; set; }
        
        public required string Student_LName { get; set; }
        public string? College { get; set; }
        [ForeignKey("Apartment")]
        public int Apartment_Id {  get; set; }
        public Apartment? Apartment { get; set; }
        List<Comment>? comments { get; set; }

    }
}
