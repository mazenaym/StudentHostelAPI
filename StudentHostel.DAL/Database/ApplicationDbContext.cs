using Microsoft.EntityFrameworkCore;
using StudentHostel.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHostel.DAL.Database
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Owner> owners { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Apartment> apartments { get; set; }
    }
}