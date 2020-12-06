using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.Models
{
    public class Actors
    {
        [Key]
        [Required]
        public int ActorID { get; set; }
        [Required]
        [Display(Name = "ActorName")]
        [MaxLength(30, ErrorMessage = "Must not be more than 30 characters")]
        public string ActorName { get; set; }
        public int FilmID { get; set; }
        public string Title { get; set; }
    }
}
