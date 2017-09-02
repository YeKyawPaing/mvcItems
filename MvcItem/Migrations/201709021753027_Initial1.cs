namespace MvcItem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "ItemName", c => c.String(maxLength: 60));
            AlterColumn("dbo.Items", "ItemCategory", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "ItemCategory", c => c.String());
            AlterColumn("dbo.Items", "ItemName", c => c.String());
        }
    }
}
