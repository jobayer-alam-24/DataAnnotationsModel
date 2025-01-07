using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get; set;}

        [Required]
        [StringLength(255)]
        [Display(Name = "Product Name")]
        public string Name {get; set;}

        [Required]
        [Range(0.001, 99999.99, ErrorMessage = "Price must be between 0.001 and 99999.99")]
        [DataType(DataType.Currency)]
        public decimal Price {get; set;}

        [StringLength(2000)]
        [Display(Name = "Product Description")]
        public string Description {get; set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-DD}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate {get; set;}
    }
}