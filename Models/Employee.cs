using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId {get; set;}

        [Required]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string FirstName {get; set;}

        [Required]
        [StringLength(100)]
        [DisplayName("Last Name")]
        public string LastName {get; set;}

        [Required]
        [Range(18, 65, ErrorMessage = "Age should be between 18 and 65")]
        public int Age {get; set;}

        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Phone]
        public string PhoneNumber {get; set;}

        [DisplayName("Date of Joining")]
        [DataType(DataType.Date)]
        public DateTime JoinDate {get; set;}
    }
}