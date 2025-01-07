using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class BookModel
    {
        [Key]
        public int BookId {get; set;}

        [Required]
        [Display(Name = "Book Title")]
        public string Title {get; set;}

        [Required]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "ISBN should be 10 or 13 characters long")]
        [Display(Name = "ISBN Number")]
        public string ISBN {get; set;}

        [Required]
        [Display(Name = "Author")]
        public string AuthorName {get; set;}
        [DataType(DataType.Date)]
        [Display(Name = "Publication Date")]
        public DateTime PublishedDate {get; set;}

        [EnumDataType(typeof(Genre))]
        [Display(Name = "Book Genre")]
        public Genre BookGenre {get; set;}
    }
    public enum Genre
    {
        Fiction, NonFiction, Biography, Children, Fantasy, Mystery
    }
}
