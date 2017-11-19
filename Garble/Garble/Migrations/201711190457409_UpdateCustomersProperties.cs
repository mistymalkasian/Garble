namespace Garble.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomersProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PickupDay", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Zip", c => c.Int());
            DropColumn("dbo.Customers", "DayofWeek");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DayofWeek", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Zip", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "PickupDay");
        }
    }
}
