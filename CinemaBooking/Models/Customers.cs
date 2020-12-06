using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.Models
{
    public class Customers
    {
        [Key]
        [Required]
        public int CustomerID { get; set; }
        [Required]
        [Display(Name="FirstName")]
        [MaxLength(30, ErrorMessage = "Must not be more than 30 characters")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name ="Surname")]
        [MaxLength(30, ErrorMessage = "Must not be more than 30 characters")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "EmailAddress")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }
    }
}
