namespace MigrationConflicts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dev2_addReaders : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Readers", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Readers");
        }
    }
}
