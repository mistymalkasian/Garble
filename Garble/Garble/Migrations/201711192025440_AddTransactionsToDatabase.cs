namespace Garble.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTransactionsToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PastTransactions",
                c => new
                    {
                        PastTransactionID = c.Int(nullable: false, identity: true),
                        PickupPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsPaid = c.Boolean(nullable: false),
                        Customer_CustomerID = c.Int(),
                    })
                .PrimaryKey(t => t.PastTransactionID)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerID)
                .Index(t => t.Customer_CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PastTransactions", "Customer_CustomerID", "dbo.Customers");
            DropIndex("dbo.PastTransactions", new[] { "Customer_CustomerID" });
            DropTable("dbo.PastTransactions");
        }
    }
}
