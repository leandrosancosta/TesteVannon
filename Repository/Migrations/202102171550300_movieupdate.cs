namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movieupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "Gender");
        }
    }
}
