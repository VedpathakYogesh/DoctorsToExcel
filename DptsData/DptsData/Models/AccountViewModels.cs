using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DptsData.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    // public class LoginViewModel
    public class DoctorsRegistrationViewModel
    {
        //[Required]
        //[Display(Name = "FirstName")]
        //[EmailAddress]
        //public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        [Required]
        [Display(Name = "EmailId")]
        [EmailAddress]
        public string EmailId { get; set; }

        [Required]
        [Display(Name = "PhoneNumber")]
        [Phone]
        public string PhoneNumber { get; set; }

       
        [Display(Name = "Gender")]
        [DataType(DataType.Text)]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "ShortProfile")]
        [DataType(DataType.Text)]
        public string ShortProfile { get; set; }

        
        [Display(Name = "RegistratioNumber")]
        [DataType(DataType.Text)]
        public string RegistrationNumber { get; set; }

        [Required]
        [Display(Name = "DateOfBirth")]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }

    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }



    }
    //public class DptsDotors
    //{
    //    [Required]
    //    [Display(Name = "FirstName")]
    //    [FirstNam]
    //    public string FirstName { get; set; }

    //    [Required]
    //    [Display(Name = "LastName")]
    //    [LastNam]
    //    public string LastName { get; set; }

    //    [Required]
    //    [Display(Name = "Email")]
    //    [EmailAddress]
    //    public string Email { get; set; }

    //    [Required]
    //    [Display(Name = "PhoneNumber")]
    //    [Phone]
    //    public string PhoneNumber { get; set; }

    //    [Required]
    //    [Display(Name = "Gender")]
    //    [Gender]
    //    public bool Gender { get; set; }

    //    [Required]
    //    [Display(Name = "ShortProfile")]
    //    [ShortProfile]
    //    public string ShortProfile { get; set; }

    //    [Display(Name = "RegistrationNumber")]
    //    [RegistrationNumber]
    //    public string RegistrationNumber { get; set; }

    //    [Required]
    //    [Display(Name = "Date Of Birth")]
    //    [Dob]
    //    public string DateOfBirth { get; set; }

    //    [Display(Name = "Remember me?")]
    //    public bool RememberMe { get; set; }

    //}

}
