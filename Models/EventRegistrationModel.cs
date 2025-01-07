using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class EventRegistrationModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Name can not be longer than 100 characters")]
        [Display(Name = "Attendee Name")]
        public string Name {get; set;}   
        
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Format..")]
        public string Email {get; set;}
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string Phone {get; set;}
        
        [Required]
        [Display(Name = "Choose Event Session")]
        public string EventSession {get; set;}
    }
}