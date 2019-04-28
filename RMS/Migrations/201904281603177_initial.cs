namespace RMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InterviewManagements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UID = c.Int(nullable: false),
                        interview_date = c.DateTime(nullable: false),
                        time = c.Time(nullable: false, precision: 7),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InterviewManagements");
        }
    }
}
