namespace _1911061930_Lekhang_bigschool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumnCoureIdOfAttendce : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Attendances", name: "Course_Id", newName: "CourseId");
            RenameIndex(table: "dbo.Attendances", name: "IX_Course_Id", newName: "IX_CourseId");
            DropPrimaryKey("dbo.Attendances");
            AddPrimaryKey("dbo.Attendances", new[] { "CourseId", "AttendeeId" });
            DropColumn("dbo.Attendances", "CourserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attendances", "CourserId", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.Attendances");
            AddPrimaryKey("dbo.Attendances", new[] { "CourserId", "AttendeeId" });
            RenameIndex(table: "dbo.Attendances", name: "IX_CourseId", newName: "IX_Course_Id");
            RenameColumn(table: "dbo.Attendances", name: "CourseId", newName: "Course_Id");
        }
    }
}
