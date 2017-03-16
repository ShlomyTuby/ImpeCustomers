namespace ImpeCustomers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "ContactUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Customers", new[] { "ContactUser_Id" });
            AddColumn("dbo.AspNetUsers", "Customer_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Customer_Id");
            AddForeignKey("dbo.AspNetUsers", "Customer_Id", "dbo.Customers", "Id");
            DropColumn("dbo.Customers", "ContactUser_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "ContactUser_Id", c => c.String(maxLength: 128));
            DropForeignKey("dbo.AspNetUsers", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.AspNetUsers", new[] { "Customer_Id" });
            DropColumn("dbo.AspNetUsers", "Customer_Id");
            CreateIndex("dbo.Customers", "ContactUser_Id");
            AddForeignKey("dbo.Customers", "ContactUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
