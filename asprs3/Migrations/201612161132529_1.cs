namespace asprs3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Activities", "ActivityFacilitator", c => c.String(nullable: false));
            AddColumn("dbo.Activities", "CurrentEnrollment", c => c.Int(nullable: false));
            AlterColumn("dbo.Activities", "ActivityStartTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Activities", "ActivityEndTime", c => c.Time(nullable: false, precision: 7));
            DropColumn("dbo.Activities", "Enrollment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Activities", "Enrollment", c => c.Int(nullable: false));
            AlterColumn("dbo.Activities", "ActivityEndTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Activities", "ActivityStartTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Activities", "CurrentEnrollment");
            DropColumn("dbo.Activities", "ActivityFacilitator");
        }
    }
}
