using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CinemaBooking.Data;
using CinemaBooking.Models;

namespace CinemaBooking.Pages.Actor
{
    public class CreateModel : PageModel
    {
        private readonly CinemaBooking.Data.ApplicationDbContext _context;

        public CreateModel(CinemaBooking.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Actors Actors { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Actors.Add(Actors);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}