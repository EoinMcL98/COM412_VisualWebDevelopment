using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaBooking.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "This is a Booking System for a Movie Theater which will allow the administrator to check all aspects of the business. It will" +
                 " also allow Customers to make booking to see films.";
        }
    }
}
