namespace BookShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteRequiredToImage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Image", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Image", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
