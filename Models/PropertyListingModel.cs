using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class PropertyListingModel
    {
        [Required]
        [DisplayName("Property Name")]
        public string PropertyName {get; set;}

        [Required]
        [Range(1, 1000, ErrorMessage = "Enter a valid number of Rooms")]
        public int Rooms {get; set;}

        [Required]
        [Display(Name = "Year Built")]
        public int YearBuilt {get; set;}

        [Required]
        [DataType(DataType.Currency)]
        [Range(1, 10000000, ErrorMessage = "Enter a valid price")]
        public decimal Price {get; set;}
        [MaxLength(1000, ErrorMessage = "Description can not be longer than 1000 characters")]
        public string Description {get; set;}
    }
}