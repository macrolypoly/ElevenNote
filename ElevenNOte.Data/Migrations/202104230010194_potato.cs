namespace ElevenNOte.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class potato : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "CategoryName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Category", "CategoryName");
        }
    }
}
