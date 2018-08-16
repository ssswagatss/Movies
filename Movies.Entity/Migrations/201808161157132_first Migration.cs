namespace Movies.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Sex = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(),
                        Bio = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ActorId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        MovieName = c.String(maxLength: 255),
                        YearOfRelease = c.Int(nullable: false),
                        Plot = c.String(),
                        PosterURL = c.String(),
                        ProducerId = c.Int(),
                    })
                .PrimaryKey(t => t.MovieId)
                .ForeignKey("dbo.Producers", t => t.ProducerId)
                .Index(t => t.ProducerId);
            
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        ProducerId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Sex = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(),
                        Bio = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ProducerId);
            
            CreateTable(
                "dbo.MovieActors",
                c => new
                    {
                        Movie_MovieId = c.Int(nullable: false),
                        Actor_ActorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_MovieId, t.Actor_ActorId })
                .ForeignKey("dbo.Movies", t => t.Movie_MovieId, cascadeDelete: false)
                .ForeignKey("dbo.Actors", t => t.Actor_ActorId, cascadeDelete: false)
                .Index(t => t.Movie_MovieId)
                .Index(t => t.Actor_ActorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "ProducerId", "dbo.Producers");
            DropForeignKey("dbo.MovieActors", "Actor_ActorId", "dbo.Actors");
            DropForeignKey("dbo.MovieActors", "Movie_MovieId", "dbo.Movies");
            DropIndex("dbo.MovieActors", new[] { "Actor_ActorId" });
            DropIndex("dbo.MovieActors", new[] { "Movie_MovieId" });
            DropIndex("dbo.Movies", new[] { "ProducerId" });
            DropTable("dbo.MovieActors");
            DropTable("dbo.Producers");
            DropTable("dbo.Movies");
            DropTable("dbo.Actors");
        }
    }
}
