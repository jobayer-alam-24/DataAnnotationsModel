using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class CustomerRegistrationViewModel
    {
        [Required]
        [Display(Name = "Full Name")]
        public string FullName {get; set;}
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [StringLength(12, MinimumLength = 5)]
        public string Password {get; set;}

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password do not match")]
        public string ConfirmPassword {get; set;}

        [Required]
        [Phone]
        public string PhoneNumber {get; set;}

        [Required]
        [Display(Name = "Shipping Address")]
        public string ShippingAddress {get; set;}
    }
}