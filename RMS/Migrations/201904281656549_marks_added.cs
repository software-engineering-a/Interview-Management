namespace RMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class marks_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InterviewManagements", "marks", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.InterviewManagements", "marks");
        }
    }
}
