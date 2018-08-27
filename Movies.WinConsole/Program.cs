using Movies.Domain.Entity;
using System;
using System.Collections.Generic;
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
                db.Movies.Add(new Movie
                {
                    MovieName = "KKKG",
                    Plot = "Plot can be anything.",
                    YearOfRelease = 2018,
                    PosterURL = "http://google.com/",
                    Producer = new Producer
                    {
                        Name = "Swagat",
                        Bio = "Good boy",
                        Sex = Entity.Enums.Gender.Male,
                        DateOfBirth = new DateTime(1992, 06, 07)
                    }
                });
                db.SaveChanges();
            }
        }
    }
}
