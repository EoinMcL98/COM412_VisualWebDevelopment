using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaBooking.Models;
using CinemaBooking.Data;

namespace CinemaBooking.Pages.Queries
{
    public class Query2Model : PageModel
    {
        public string StringSearch { get; set; }
        public string SearchString { get; set; }
        public IList<Actors> Actor { get; set; }

        private readonly CinemaBooking.Data.ApplicationDbContext _context;

        public Query2Model(CinemaBooking.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            var Acts = from a in _context.Actors
                        select a;

            var Film = from f in _context.Actors
                       select f;

            if (!string.IsNullOrEmpty(SearchString))
            {
                Acts = Acts.Where(n => n.ActorName.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(StringSearch))
            {
                Film = Film.Where(t => t.Title.Contains(StringSearch));
            }

            Actor = await Acts.ToListAsync();
            Actor = await Film.ToListAsync();

        }
    }
}