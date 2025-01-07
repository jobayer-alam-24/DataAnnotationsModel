using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsModel.Models
{
    public class RoomBookingModel
    {
        [Key]
        public int BookingId {get; set;}
        [Required]
        [Display(Name = "Guest Name")]
        public string GuestName {get; set;}

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Check-In Date")]
        public DateTime CheckInDate {get; set;}
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Check-Out Date")]
        public DateTime CheckOutDate {get; set;}
        [Required]
        [EnumDataType(typeof(RoomType))]
        [Display(Name = "Room Type")]
        public RoomType TypeOfRoom {get; set;}

    }
    public enum RoomType
    {
        Single, Double, Suite
    }
}