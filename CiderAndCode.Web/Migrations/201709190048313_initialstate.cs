namespace CiderAndCode.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialstate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppleFacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Fact = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bushels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Ripe = c.Boolean(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ciders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        DatePressed = c.DateTime(nullable: false),
                        TastingNotes = c.String(),
                        Filtered = c.Boolean(nullable: false),
                        NumberOfGallons = c.Int(nullable: false),
                        Bushel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bushels", t => t.Bushel_Id)
                .Index(t => t.Bushel_Id);
            
            CreateTable(
                "dbo.Drinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cider_Id = c.Int(),
                        Juice_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ciders", t => t.Cider_Id)
                .ForeignKey("dbo.Juices", t => t.Juice_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Cider_Id)
                .Index(t => t.Juice_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Juices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateFiltered = c.DateTime(nullable: false),
                        Healthy = c.Boolean(nullable: false),
                        Cider_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ciders", t => t.Cider_Id)
                .Index(t => t.Cider_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Drinks", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Drinks", "Juice_Id", "dbo.Juices");
            DropForeignKey("dbo.Juices", "Cider_Id", "dbo.Ciders");
            DropForeignKey("dbo.Drinks", "Cider_Id", "dbo.Ciders");
            DropForeignKey("dbo.Ciders", "Bushel_Id", "dbo.Bushels");
            DropForeignKey("dbo.Bushels", "User_Id", "dbo.Users");
            DropIndex("dbo.Juices", new[] { "Cider_Id" });
            DropIndex("dbo.Drinks", new[] { "User_Id" });
            DropIndex("dbo.Drinks", new[] { "Juice_Id" });
            DropIndex("dbo.Drinks", new[] { "Cider_Id" });
            DropIndex("dbo.Ciders", new[] { "Bushel_Id" });
            DropIndex("dbo.Bushels", new[] { "User_Id" });
            DropTable("dbo.Juices");
            DropTable("dbo.Drinks");
            DropTable("dbo.Ciders");
            DropTable("dbo.Users");
            DropTable("dbo.Bushels");
            DropTable("dbo.AppleFacts");
        }
    }
}
