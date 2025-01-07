using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class ProductReviewModel
    {
        [Required]
        public int ProductID {get; set;}

        [Required]
        [Range(1, 5)]
        public int Rating {get; set;}

        [Required]
        [MaxLength(1000, ErrorMessage = "Review Can not exceed 1000 characters")]
        public string Review {get; set;}
        [Required]
        [Display(Name = "Reviewed By")]
        public string ReviewerName {get; set;}
    }
}