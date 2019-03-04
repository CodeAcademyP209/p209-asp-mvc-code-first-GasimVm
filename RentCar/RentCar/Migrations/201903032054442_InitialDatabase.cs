namespace RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brend = c.String(maxLength: 100),
                        Model = c.String(maxLength: 100),
                        Fuel = c.String(maxLength: 100),
                        Year = c.Int(nullable: false),
                        Horseshoe = c.Int(nullable: false),
                        March = c.Int(nullable: false),
                        Capacity = c.Double(nullable: false),
                        Image = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
