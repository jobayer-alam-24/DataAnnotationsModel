using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class MembershipModel
    {
        [Required]
        [Display(Name = "Full Name")]
        public string FullName {get; set;}

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth {get; set;}

        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Required]
        [Range(1, 12, ErrorMessage = "Select a valid Membership Duration")]
        [Display(Name = "Duration (In Months)")]
        public int Duration {get; set;}
    }
}