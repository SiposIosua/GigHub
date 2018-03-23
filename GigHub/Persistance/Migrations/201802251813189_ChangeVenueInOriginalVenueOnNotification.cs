namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeVenueInOriginalVenueOnNotification : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifications", "OriginalVenue", c => c.String());
            DropColumn("dbo.Notifications", "Venue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Notifications", "Venue", c => c.String());
            DropColumn("dbo.Notifications", "OriginalVenue");
        }
    }
}
