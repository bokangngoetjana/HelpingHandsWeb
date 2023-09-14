using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HelpingHands.Data
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "First name must not exceed 50 characters")]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Last name must not exceed 50 characters")]
        public string LastName { get; set; }


        [Required]
        [Display(Name = "Gender")]
        [StringLength(6, ErrorMessage = "Gender must not exceed 6 characters"), MinLength(4)]
        public string Gender { get; set; }


        [Display(Name = "Emergency Contact Name")]
        public string EmergencyContactName { get; set; }

        [Required]
        [Display(Name = "Contact No")]
        [StringLength(10, ErrorMessage = "Contact Number must only be 10 digits")]
        public string EmergencyContactNo { get; set; }

        [Required]
        [Display(Name = "Identity Number")]
        [StringLength(13, ErrorMessage = "Identity Number must be exactly 13 characters.")]
        public string IDNumber { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DoB { get; set; }
    }
}
