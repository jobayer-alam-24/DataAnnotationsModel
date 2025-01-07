using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class WorkshopBookingModel
    {
        [Required]
        [Display(Name = "Attendee Name")]
        public string AttendeeName {get; set;}

        [Required]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        [Display(Name = "Preferred Date")]
        [DataType(DataType.Date)]
        public DateTime PreferredDate {get; set;}

        [Required]
        [Display(Name = "Workshop Topic")]
        public string WorkshopTopic {get; set;}
    }
}