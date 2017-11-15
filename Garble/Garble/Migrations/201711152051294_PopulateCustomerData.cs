namespace Garble.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerData : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO Customers (CustomerID, FirstName, LastName) VALUES (1, Misty, Malkasian)");
            //Sql("INSERT INTO Customers (CustomerID, FirstName, LastName) VALUES (2, Sherlock, Holmes)");
            //Sql("INSERT INTO Customers (CustomerID, FirstName, LastName) VALUES (3, Link, OfHyrule)");
        }
        
        public override void Down()
        {
        }
    }
}
