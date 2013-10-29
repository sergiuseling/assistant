namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUser : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.User", "EnrollmentDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "EnrollmentDate", c => c.DateTime(nullable: false));
        }
    }
}
