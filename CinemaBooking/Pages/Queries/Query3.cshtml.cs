using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CinemaBooking.Models;
using CinemaBooking.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CinemaBooking.Pages.Queries
{
    public class Query3Model : PageModel
    {
        public IList<Bookings> Booking { get; set; }
        private readonly CinemaBooking.Data.ApplicationDbContext _context;

        public Query3Model(CinemaBooking.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            decimal maxNum, minNum;
            
            //Gets the film with the genre matched with the input genre

            var number = from n in _context.Bookings
                         select n.Price;

            maxNum = number.Max();
            minNum = number.Min();

            ViewData["MaxMinQuery"] = $"The maximum price paid is {maxNum}" +
                $"The minimum price paid is {minNum}";
        }




    }
}