namespace Movies.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manytomanyrelation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActorMovies",
                c => new
                    {
                        Actor_UserId = c.Int(nullable: false),
                        Movie_MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Actor_UserId, t.Movie_MovieId })
                .ForeignKey("dbo.Users", t => t.Actor_UserId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieId, cascadeDelete: true)
                .Index(t => t.Actor_UserId)
                .Index(t => t.Movie_MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ActorMovies", "Movie_MovieId", "dbo.Movies");
            DropForeignKey("dbo.ActorMovies", "Actor_UserId", "dbo.Users");
            DropIndex("dbo.ActorMovies", new[] { "Movie_MovieId" });
            DropIndex("dbo.ActorMovies", new[] { "Actor_UserId" });
            DropTable("dbo.ActorMovies");
        }
    }
}
