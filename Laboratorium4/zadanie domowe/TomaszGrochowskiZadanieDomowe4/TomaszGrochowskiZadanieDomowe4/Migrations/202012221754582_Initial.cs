namespace TomaszGrochowskiZadanieDomowe3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccessibilityTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        AnimalTypeId = c.Int(nullable: false),
                        PopulationId = c.Int(nullable: false),
                        RegionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AnimalTypes", t => t.AnimalTypeId, cascadeDelete: true)
                .ForeignKey("dbo.PopulationStatus", t => t.PopulationId, cascadeDelete: true)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .Index(t => t.AnimalTypeId)
                .Index(t => t.PopulationId)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.AnimalTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PopulationStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Area = c.String(nullable: false),
                        AccessibilityTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccessibilityTypes", t => t.AccessibilityTypeId, cascadeDelete: true)
                .Index(t => t.AccessibilityTypeId);
            
            CreateTable(
                "dbo.Keepers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        ContactNumber = c.String(nullable: false, maxLength: 9),
                        LodgeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lodges", t => t.LodgeId, cascadeDelete: true)
                .Index(t => t.LodgeId);
            
            CreateTable(
                "dbo.Lodges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Mushrooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Edibility = c.String(nullable: false),
                        RegionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mushrooms", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Keepers", "LodgeId", "dbo.Lodges");
            DropForeignKey("dbo.Lodges", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Animals", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Regions", "AccessibilityTypeId", "dbo.AccessibilityTypes");
            DropForeignKey("dbo.Animals", "PopulationId", "dbo.PopulationStatus");
            DropForeignKey("dbo.Animals", "AnimalTypeId", "dbo.AnimalTypes");
            DropIndex("dbo.Mushrooms", new[] { "RegionId" });
            DropIndex("dbo.Lodges", new[] { "RegionId" });
            DropIndex("dbo.Keepers", new[] { "LodgeId" });
            DropIndex("dbo.Regions", new[] { "AccessibilityTypeId" });
            DropIndex("dbo.Animals", new[] { "RegionId" });
            DropIndex("dbo.Animals", new[] { "PopulationId" });
            DropIndex("dbo.Animals", new[] { "AnimalTypeId" });
            DropTable("dbo.Users");
            DropTable("dbo.Mushrooms");
            DropTable("dbo.Lodges");
            DropTable("dbo.Keepers");
            DropTable("dbo.Regions");
            DropTable("dbo.PopulationStatus");
            DropTable("dbo.AnimalTypes");
            DropTable("dbo.Animals");
            DropTable("dbo.AccessibilityTypes");
        }
    }
}
