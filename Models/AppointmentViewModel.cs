using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class AppointmentViewModel
    {
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Appointment Date")]
        public DateTime Date {get; set;}
        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Preffered Time")]   
        public DateTime Time {get; set;}
        [Required]
        [Display(Name = "Reason For Visit")]
        public string Reason {get; set;}
        [Required]
        [Phone]
        [Display(Name = "Contact Number")]
        public string ContactNumber {get; set;}
    }
}