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
    public class Query1Model : PageModel
    {

        public SelectList Films { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FilmGenre { get; set; }

        public IList<Films> Film { get; set; }
        private readonly CinemaBooking.Data.ApplicationDbContext _context;

        public Query1Model(CinemaBooking.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            //Gathers a list of films 
            IQueryable<string> genreQuery = from g in _context.Films
                                            select g.Genre;

            //Gets the film with the genre matched with the input genre
            var GenreFilm = from g in _context.Films
                            where g.Genre == FilmGenre
                            select g;

            Films = new SelectList(await genreQuery.Distinct().ToListAsync());
            Film = await GenreFilm.ToListAsync();
        }
    }
}  