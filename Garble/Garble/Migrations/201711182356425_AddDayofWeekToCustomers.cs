namespace Garble.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDayofWeekToCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DayofWeek", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DayofWeek");
        }
    }
}
