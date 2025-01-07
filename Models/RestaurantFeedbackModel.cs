using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class RestaurantFeedbackModel
    {   
        [Required]
        [Display(Name = "Your Name")]
        public string CustomerName {get; set;}   

        [Required]
        [Range(1, 5, ErrorMessage = "Please select a rating between 1 to 5")]
        public int Rating {get; set;}     

        [StringLength(500, ErrorMessage = "Feedback can not exceed above 500 characters")]
        public string FeedBack {get; set;}

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email (optional)")]
        public string Email {get; set;}
    }
}