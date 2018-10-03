namespace OnlineShoppingStore.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductModelCHanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Category", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Category", c => c.String());
        }
    }
}
