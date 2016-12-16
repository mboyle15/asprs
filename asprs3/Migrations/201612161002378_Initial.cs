namespace asprs3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ActivityId = c.Int(nullable: false, identity: true),
                        ActivityName = c.String(nullable: false),
                        ActivityLocation = c.String(nullable: false),
                        ActivityStartTime = c.DateTime(nullable: false),
                        ActivityEndTime = c.DateTime(nullable: false),
                        DailyCost = c.Int(nullable: false),
                        Cost = c.Int(nullable: false),
                        Capacity = c.Int(nullable: false),
                        Enrollment = c.Int(nullable: false),
                        EligibleGrades = c.String(nullable: false),
                        OfferedDays = c.String(nullable: false),
                        Quarter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ActivityId);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        Enrollment_Id = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        ActivityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Enrollment_Id)
                .ForeignKey("dbo.Activities", t => t.ActivityId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.ActivityId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentFName = c.String(nullable: false),
                        StudentLName = c.String(nullable: false),
                        StudentDOB = c.DateTime(nullable: false),
                        StudentGrade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "ActivityId", "dbo.Activities");
            DropIndex("dbo.Enrollments", new[] { "ActivityId" });
            DropIndex("dbo.Enrollments", new[] { "StudentID" });
            DropTable("dbo.Students");
            DropTable("dbo.Enrollments");
            DropTable("dbo.Activities");
        }
    }
}
