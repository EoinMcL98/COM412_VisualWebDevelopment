using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaBooking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CinemaBooking.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for Actors
                if (context.Actors.Any() || context.Bookings.Any())
                {
                    return; // DB has been seeded
                }
                context.Actors.AddRange(
                    new Actors
                    {
                        ActorName = "Leonardo DiCaprio",
                        Title = "Once Upon A Time In Hollywood"
                    },
                    new Actors
                    {
                        ActorName = "Robert De Niro",
                        Title = "The Irishman"
                    },
                    new Actors
                    {
                        ActorName = "Chadwick Boseman",
                        Title = "21 Bridges"
                    }
                );
                context.SaveChanges();


                context.Bookings.AddRange(
                new Bookings
                {
                    Date = DateTime.Parse("14/12/2019"),
                    Price = 15.50M
                },
                new Bookings
                {
                    Date = DateTime.Parse("17/11/2019"),
                    Price = 14.50M
                },
                new Bookings
                {
                    Date = DateTime.Parse("14/10/2019"),
                    Price = 10.00M
                }
                );
                context.SaveChanges();


                if (context.Customers.Any() || context.Films.Any())
                {
                    return; //Seeded Databse
                }
                context.Customers.AddRange(
                    new Customers
                    {
                        FirstName = "Joe",
                        Surname = "Bloggs",
                        EmailAddress = "jblogss@gmail.com"
                    },
                    new Customers
                    {
                        FirstName = "William",
                        Surname = "Schmidt",
                        EmailAddress = "BillSchimdt@hotmail.co.uk"
                    },
                    new Customers
                    {
                        FirstName = "Bruce",
                        Surname = "O'Neill",
                        EmailAddress = "Bruceoneill@yahoo.co.uk"
                    }
                );
                context.SaveChanges();


                if (context.Films.Any())
                {
                    return; //Database Seeded
                }
                context.Films.AddRange(
                    new Films
                    {
                        FilmTitle = "Once Upon A Time In Hollywood",
                        ReleaseDate = DateTime.Parse("14/08/2019"),
                        Genre = "Comedy-Drama"
                    },
                    new Films
                    {
                        FilmTitle = "The Irishman",
                        ReleaseDate = DateTime.Parse("08/11/2019"),
                        Genre = "Drama/Crime"
                    },
                    new Films
                    {
                        FilmTitle = "21 Bridges",
                        ReleaseDate = DateTime.Parse("22/11/2019"),
                        Genre = "Drama/Mystery"
                    }
                );
                context.SaveChanges();

            }
        }
    }
}