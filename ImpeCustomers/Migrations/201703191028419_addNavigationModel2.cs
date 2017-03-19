namespace ImpeCustomers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNavigationModel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Navigations", "Index", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AddColumn("dbo.Navigations", "IndexPosition", c => c.Int(nullable: false));
        }
    }
}
