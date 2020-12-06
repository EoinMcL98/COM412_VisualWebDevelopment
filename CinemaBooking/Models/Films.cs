using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.Models
{
    public class Films
    {
        [Key]
        public int FilmID { get; set; }
        [Required]
        [Display(Name = "FilmTitle")]
        [MaxLength(30, ErrorMessage = "Must not be more than 30 characters")]
        public string FilmTitle { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Genre")]
        [MaxLength(30, ErrorMessage = "Must not be more than 30 characters")]
        public string Genre { get; set; }
    }
}
