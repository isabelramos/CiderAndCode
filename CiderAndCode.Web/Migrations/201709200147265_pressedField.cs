namespace CiderAndCode.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pressedField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bushels", "Pressed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bushels", "Pressed");
        }
    }
}
