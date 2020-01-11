namespace ECommerceApp.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateNEwColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "IsHome", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "IsHome");
        }
    }
}
