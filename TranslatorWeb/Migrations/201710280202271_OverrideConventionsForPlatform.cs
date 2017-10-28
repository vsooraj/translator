namespace TranslatorWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForPlatform : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Platforms", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Platforms", "ImageUrl", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Platforms", "ImageUrl", c => c.String());
            AlterColumn("dbo.Platforms", "Name", c => c.String());
        }
    }
}
