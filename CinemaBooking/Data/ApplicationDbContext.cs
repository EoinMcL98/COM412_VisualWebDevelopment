using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CinemaBooking.Models;

namespace CinemaBooking.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CinemaBooking.Models.Actors> Actors { get; set; }
        public DbSet<CinemaBooking.Models.Bookings> Bookings { get; set; }
        public DbSet<CinemaBooking.Models.Customers> Customers { get; set; }
        public DbSet<CinemaBooking.Models.Films> Films { get; set; }
        
    }
}
