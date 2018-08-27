using Movies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.WinConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MovieContext())
            {
                //db.Movies.Add(new Movie
                //{
                //    MovieName = "KKKG",
                //    Plot = "Plot can be anything.",
                //    YearOfRelease = 2018,
                //    PosterURL = "http://google.com/",
                //    Producer = new Producer
                //    {
                //        Name = "Swagat",
                //        Bio = "Good boy",
                //        Sex = Entity.Enums.Gender.Male,
                //        DateOfBirth = new DateTime(1992, 06, 07)
                //    }
                //});
                //db.SaveChanges();

                //Add Actors to movies
                //var movie = db.Movies.FirstOrDefault();
                //if (movie != null)
                //{
                //    movie.Actors.Add(new Actor {
                //        Name = "Bikash",
                //        Bio = "Bad boy",
                //        Sex = Entity.Enums.Gender.Male,
                //        DateOfBirth = new DateTime(1990, 06, 07)
                //    });
                //    db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                //    db.SaveChanges();
                //}

                //Fetch And print all the details for movie

                var movies = db.Movies.Include(x => x.Actors).Include(x => x.Producer).ToList();

                foreach (var m in movies)
                {
                    Console.WriteLine($"Movie Name : - {m.MovieName} - Year - {m.YearOfRelease}");
                    Console.WriteLine($"Producer - {m.Producer.Name}");
                    Console.WriteLine("Actors - ");
                    foreach (var a in m.Actors)
                    {
                        Console.WriteLine($"Name - {a.Name}");
                    }

                }

            }

            Console.WriteLine("Press any key to exist..");
            Console.ReadKey();
        }
    }
}
