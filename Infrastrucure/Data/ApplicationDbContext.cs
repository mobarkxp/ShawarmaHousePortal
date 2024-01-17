using Domin.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ShawarmaHousePortal.Models;

namespace ShawarmaHousePortal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           // Database.EnsureCreated();
        }
      
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Job>? Jobs { get; set; }
        public DbSet<Education>? Educations { get; set; }
        public DbSet<City>? Cities { get; set; }
        public DbSet<Gender>? Genders { get; set; }
        public DbSet<Injuored>? Injuoreds { get; set; }
        public DbSet<Maried>? marieds  { get; set; }
        public DbSet<Surjury>? Surjuries  { get; set; }
        public DbSet<Work>? Works  { get; set; }
        public DbSet<JobShoosed>? JobsShoosed  { get; set; }


    }
}