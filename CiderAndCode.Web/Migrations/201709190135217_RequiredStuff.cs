namespace CiderAndCode.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredStuff : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ciders", "TastingNotes", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ciders", "TastingNotes", c => c.String());
        }
    }
}
