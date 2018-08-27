namespace Movies.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false),
                        MovieName = c.String(maxLength: 255),
                        YearOfRelease = c.Int(nullable: false),
                        Plot = c.String(),
                        PosterURL = c.String(),
                    })
                .PrimaryKey(t => t.MovieId)
                .ForeignKey("dbo.Users", t => t.MovieId)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Sex = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(),
                        Bio = c.String(maxLength: 500),
                        UserProfile = c.Int(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieId", "dbo.Users");
            DropIndex("dbo.Movies", new[] { "MovieId" });
            DropTable("dbo.Users");
            DropTable("dbo.Movies");
        }
    }
}
