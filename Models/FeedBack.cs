using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class Feedback
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Your Name")]
        public string Name {get; set;}

        [Required]
        [EmailAddress]
        [Display(Name = "Your Mail")]
        public string Email {get; set;}

        [Required]
        [StringLength(1000, ErrorMessage = "Messege Should not be more than 1000 characters")]
        [DataType(DataType.MultilineText)]
        public string Messege {get; set;}
    }
}