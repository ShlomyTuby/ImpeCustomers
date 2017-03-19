namespace ImpeCustomers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNavigationModel1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Navigations", new[] { "ParentId" });
            AlterColumn("dbo.Navigations", "ParentId", c => c.Int());
            CreateIndex("dbo.Navigations", "ParentId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Navigations", new[] { "ParentId" });
            AlterColumn("dbo.Navigations", "ParentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Navigations", "ParentId");
        }
    }
}
