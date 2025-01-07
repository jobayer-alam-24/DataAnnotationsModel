using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class BlogPostViewModel
    {
        [Required]
        [StringLength(200)]
        [Display(Name = "Blog Title")]
        public string BlogTitle {get; set;}

        [Required]
        [StringLength(5000)]
        public string Content {get; set;}
   
        [DataType(DataType.Date)]
        [Display(Name = "Publish Date")]
        public DateTime PublishDate {get; set;}
        
        [Display(Name = "Author's Email")]
        [EmailAddress]
        public string AuthorEmail {get; set;}
    }
}