namespace CustomerTable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class try2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CountryName", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "StateName", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "CountryId");
            DropColumn("dbo.Customers", "StateId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "StateId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "CountryId", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "StateName");
            DropColumn("dbo.Customers", "CountryName");
        }
    }
}
