namespace Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddsActortable : DbMigration
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
        }
        
        public override void Down()
        {
            DropTable("dbo.Actors");
        }
    }
}
