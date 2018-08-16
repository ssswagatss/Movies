namespace Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OtherTablesadded : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "ProducerId", "dbo.Producers");
            DropIndex("dbo.Movies", new[] { "ProducerId" });
            DropTable("dbo.Producers");
            DropTable("dbo.Movies");
        }
    }
}
