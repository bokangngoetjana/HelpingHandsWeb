using HelpingHands.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HelpingHands.Data
{
    
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "First name must not exceed 50 characters")]
        public string? FirstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "First name must not exceed 50 characters")]
        public string? LastName { get; set; }


        [Required]
        [Display(Name = "Gender")]
        public string? Gender { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string? AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string? AddressLine2 { get; set; }

        [Required]
        [Display(Name = "Identity Number")]
        [StringLength(13, ErrorMessage = "Identity Number must be exactly 13 characters."), MinLength(13)]
        public string? IDNumber { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Emergency Contact Name")]
        public string? EmergencyPerson { get; set; }

        [Required]
        [Display(Name = "Emergency Phone Number")]
        [StringLength(10, ErrorMessage = "Contact Number must only be 10 digits")]
        public string? EmergencyContactNo { get; set; }

        //SuburbID FK


    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}