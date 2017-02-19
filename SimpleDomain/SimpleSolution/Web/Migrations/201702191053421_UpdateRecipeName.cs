namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRecipeName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Recipe", "Name", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Recipe", "Name", c => c.String());
        }
    }
}
