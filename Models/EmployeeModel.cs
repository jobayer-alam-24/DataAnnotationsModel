using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class EmployeeModel
    {
        [Key]
        public string EmployeeId {get; set;}

        [Required]
        [Display(Name = "First Name")] 
        public string FirstName {get; set;} 

        [Required]
        [Display(Name = "Last Name")]
        public string LastName {get; set;}

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email {get; set;}

        [Required]
        [Phone]
        [Display(Name = "Contact Number")]
        public string PhoneNumber {get; set;}

        [Required]
        [EnumDataType(typeof(Role))]
        [Display(Name = "Job Role")]
        public Role EmployeeRole {get; set;}

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Joining Date")]
        public DateTime JoinDate {get; set;}
    }
    public enum Role{
        Admin,
        Manager,
        Developer,
        Designer, 
        Sales
    }
}