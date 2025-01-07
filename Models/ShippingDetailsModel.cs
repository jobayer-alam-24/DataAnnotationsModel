using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class ShippingDetailsModel
    {
        [Required]
        [Display(Name = "Recipient's Name")]
        public string RecipientName {get; set;}

        [Required]
        [StringLength(200, ErrorMessage = "Address is TOO Long!")]
        public string Address {get; set;}

        [Required]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Invalid Zip Code")]
        public string ZipCode {get; set;}
        [Required]
        [Phone]
        [Display(Name = "Contact Number")]
        public string PhoneNumeber {get; set;}
    }
}