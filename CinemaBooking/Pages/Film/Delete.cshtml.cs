using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CinemaBooking.Data;
using CinemaBooking.Models;

namespace CinemaBooking.Pages.Film
{
    public class DeleteModel : PageModel
    {
        private readonly CinemaBooking.Data.ApplicationDbContext _context;

        public DeleteModel(CinemaBooking.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Films Films { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Films = await _context.Films.FirstOrDefaultAsync(m => m.FilmID == id);

            if (Films == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Films = await _context.Films.FindAsync(id);

            if (Films != null)
            {
                _context.Films.Remove(Films);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
