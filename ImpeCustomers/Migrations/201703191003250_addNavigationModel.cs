namespace ImpeCustomers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNavigationModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Navigations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsRoot = c.Boolean(nullable: false),
                        Url = c.String(),
                        ParentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Navigations", t => t.ParentId)
                .Index(t => t.ParentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Navigations", "ParentId", "dbo.Navigations");
            DropIndex("dbo.Navigations", new[] { "ParentId" });
            DropTable("dbo.Navigations");
        }
    }
}
