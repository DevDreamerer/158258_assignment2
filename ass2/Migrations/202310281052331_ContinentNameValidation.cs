namespace ass2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContinentNameValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Continents", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Endangereds", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Endangereds", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Endangereds", "Description", c => c.String());
            AlterColumn("dbo.Endangereds", "Name", c => c.String());
            AlterColumn("dbo.Continents", "Name", c => c.String());
        }
    }
}
