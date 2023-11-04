namespace ass2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Continents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Endangereds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Number = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        ContinentID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Continents", t => t.ContinentID)
                .Index(t => t.ContinentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Endangereds", "ContinentID", "dbo.Continents");
            DropIndex("dbo.Endangereds", new[] { "ContinentID" });
            DropTable("dbo.Endangereds");
            DropTable("dbo.Continents");
        }
    }
}
