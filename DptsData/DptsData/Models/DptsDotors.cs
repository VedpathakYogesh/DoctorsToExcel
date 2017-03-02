using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DptsData.Models
{
    public class DptsDotors
    {
        [Required]
        [Display(Name = "FirstName")]
        
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "LastName")]
        
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "PhoneNumber")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Gender")]
        
        public string Gender { get; set; }

        [Required]
        [Display(Name = "ShortProfile")]
        [ShortProfile]
        public string ShortProfile { get; set; }

        [Display(Name = "RegistrationNumber")]
        [RegistrationNumber]
        public string RegistrationNumber { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [Dob]
        public string DateOfBirth { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

    }

    internal class DobAttribute : Attribute
    {
    }

    internal class RegistrationNumberAttribute : Attribute
    {
    }

    internal class ShortProfileAttribute : Attribute
    {
    }
}