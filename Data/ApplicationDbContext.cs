using HelpingHands.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HelpingHands.Data
{
    //{ 
    //    public class ApplicationUser : IdentityUser
    //    {
    //        public string? FirstName { get; set; }
    //        public string? LastName { get; set; }
    //        public string? Gender { get; set; }
    //        public DateOnly DateOfBirth { get; set; }
    //        public string? EmergencyPerson { get; set; }
    //        public string? EmergencyContactNo { get; set; }
    //    }
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //}
            //public DbSet<City> City { get; set; }
        }
    }
}