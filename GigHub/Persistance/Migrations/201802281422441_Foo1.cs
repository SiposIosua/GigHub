namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Foo1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.UserNotifications");
            AddPrimaryKey("dbo.UserNotifications", new[] { "UserId", "NotificationId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.UserNotifications");
            AddPrimaryKey("dbo.UserNotifications", new[] { "NotificationId", "UserId" });
        }
    }
}
