using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CinemaBooking.Data;
using CinemaBooking.Models;

namespace CinemaBooking.Pages.Booking
{
    public class IndexModel : PageModel
    {
        private readonly CinemaBooking.Data.ApplicationDbContext _context;

        public IndexModel(CinemaBooking.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Bookings> Bookings { get;set; }

        public async Task OnGetAsync()
        {
            Bookings = await _context.Bookings.ToListAsync();
        }
    }
}
