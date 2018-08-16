namespace Movies.Entity.Migrations
{
    using Movies.Domain.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            if (!context.Actors.Any())
            {
                var producer = new Producer
                {
                    Name = "Himanshu Sekhar",
                    Sex = Enums.Gender.Male,
                    Bio = "The best producer of Mindfire",
                    DateOfBirth = new DateTime(1988, 04, 09),
                };
                var actor = new Actor()
                {
                    Name = "Pradeep Maharathi",
                    Sex = Enums.Gender.Male,
                    Bio = "He is a very sexy and seductive actor.",
                    DateOfBirth = new DateTime(1991, 01, 01),
                    Movies = new List<Movie>()
                    {
                        new Movie {
                            MovieName="Sultan",
                            Plot="Movie is based on a serial kisser",
                            PosterURL= "https://m.media-amazon.com/images/M/MV5BNDc0OTU3M2MtMGFhMi00ZGVlLWI4YmItODA1ZTc0OGY0NmJlXkEyXkFqcGdeQXVyNjQ2MjQ5NzM@._V1_.jpg",
                            YearOfRelease=2018,
                            Producer=producer
                        },
                        new Movie {
                            MovieName="Murder",
                            Plot="Movie is based on a serial killer",
                            PosterURL= "https://akm-img-a-in.tosshub.com/indiatoday/images/story/201806/murder2_647.jpeg?5mwgQP4Yh1LsdkAPE9k0pAd45o4NkIUr",
                            YearOfRelease=2017,
                            Producer=producer
                        }
                    }
                };
                context.Actors.Add(actor);
                context.SaveChanges();
            }
        }
    }
}
