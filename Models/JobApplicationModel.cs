using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class JobApplicationModel
    {
        [Required(ErrorMessage = "Please enter your First Name")]
        [Display(Name = "First Name")]   
        public string FirstName {get; set;}

        [Required(ErrorMessage = "Please enter your Last Name")]
        [Display(Name = "Last Name")]
        public string LastName {get; set;}

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email {get; set;}

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber {get; set;}

        [Required]
        [Display(Name = "Position Applying For")]
        public string Position {get; set;}

        [DataType(DataType.Upload)]
        [Display(Name = "Upload Resume")]
        public IFormFile Resume {get; set;}
    }
}