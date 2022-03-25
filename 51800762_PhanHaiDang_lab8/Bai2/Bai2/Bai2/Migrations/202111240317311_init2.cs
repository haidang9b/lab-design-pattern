namespace Bai2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.NewsLocals", newName: "NewsLocal");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.NewsLocal", newName: "NewsLocals");
        }
    }
}
