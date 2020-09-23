namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOrderModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItems", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.OrderItems", "Prices");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderItems", "Prices", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.OrderItems", "Price");
        }
    }
}
