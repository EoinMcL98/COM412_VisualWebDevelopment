using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaBooking.Data;
using CinemaBooking.Models;

namespace CinemaBooking.Pages.Actor
{
    public class EditModel : PageModel
    {
        private readonly CinemaBooking.Data.ApplicationDbContext _context;

        public EditModel(CinemaBooking.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Actors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActorsExists(Actors.ActorID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ActorsExists(int id)
        {
            return _context.Actors.Any(e => e.ActorID == id);
        }
    }
}
