namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CPF = c.String(maxLength: 11),
                        Name = c.String(maxLength: 40),
                        TelNumber = c.String(maxLength: 11),
                        Email = c.String(maxLength: 80),
                        Stats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 40),
                        ParentalGuide = c.Int(nullable: false),
                        Resume = c.String(maxLength: 240),
                        Released = c.DateTime(nullable: false),
                        Stats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rent",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                        RentDate = c.DateTime(nullable: false),
                        Return = c.DateTime(nullable: false),
                        Stats = c.Int(nullable: false),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Movie", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rent", "MovieId", "dbo.Movie");
            DropForeignKey("dbo.Rent", "CustomerId", "dbo.Customer");
            DropIndex("dbo.Rent", new[] { "MovieId" });
            DropIndex("dbo.Rent", new[] { "CustomerId" });
            DropTable("dbo.Rent");
            DropTable("dbo.Movie");
            DropTable("dbo.Customer");
        }
    }
}
