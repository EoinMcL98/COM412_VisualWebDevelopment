using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.Models
{
    [BindProperties]
    public class CustomerBooking
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Customers> Customer { get; set; }

        public int BookingID { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public List<Bookings> Booking { get; set; }
    }
}
