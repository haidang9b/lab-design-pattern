namespace Bai2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewsCategory",
                c => new
                    {
                        categoryId = c.Int(nullable: false, identity: true),
                        categoryName = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.categoryId);
            
            CreateTable(
                "dbo.NewsLocals",
                c => new
                    {
                        newsId = c.Int(nullable: false, identity: true),
                        newsTitle = c.String(maxLength: 300),
                        newsContent = c.String(),
                        categoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.newsId)
                .ForeignKey("dbo.NewsCategory", t => t.categoryId, cascadeDelete: true)
                .Index(t => t.categoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewsLocals", "categoryId", "dbo.NewsCategory");
            DropIndex("dbo.NewsLocals", new[] { "categoryId" });
            DropTable("dbo.NewsLocals");
            DropTable("dbo.NewsCategory");
        }
    }
}
