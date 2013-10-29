namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserTask",
                c => new
                    {
                        UserTaskID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        Start = c.DateTime(),
                        End = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserTaskID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstMidName = c.String(),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTask", "UserID", "dbo.User");
            DropIndex("dbo.UserTask", new[] { "UserID" });
            DropTable("dbo.User");
            DropTable("dbo.UserTask");
        }
    }
}
