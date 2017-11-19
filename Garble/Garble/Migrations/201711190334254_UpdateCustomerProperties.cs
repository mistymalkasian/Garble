namespace Garble.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "VacationStartDate", c => c.DateTime());
            AddColumn("dbo.Customers", "VacationEndDate", c => c.DateTime());
            AddColumn("dbo.Customers", "Address", c => c.String());
            AddColumn("dbo.Customers", "Zip", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Zip");
            DropColumn("dbo.Customers", "Address");
            DropColumn("dbo.Customers", "VacationEndDate");
            DropColumn("dbo.Customers", "VacationStartDate");
        }
    }
}
