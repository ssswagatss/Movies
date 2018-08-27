namespace Movies.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removesuserprofile : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "UserProfile");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserProfile", c => c.Int(nullable: false));
        }
    }
}
