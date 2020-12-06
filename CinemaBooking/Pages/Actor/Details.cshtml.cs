using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CinemaBooking.Data;
using CinemaBooking.Models;

namespace CinemaBooking.Pages.Actor
{
    public class DetailsModel : PageModel
    {
        private readonly CinemaBooking.Data.ApplicationDbContext _context;

        public DetailsModel(CinemaBooking.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Actors Actors { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Actors = await _context.Actors.FirstOrDefaultAsync(m => m.ActorID == id);

            if (Actors == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
