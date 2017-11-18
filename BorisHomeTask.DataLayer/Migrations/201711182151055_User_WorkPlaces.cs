namespace BorisHomeTask.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User_WorkPlaces : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Surname = c.String(maxLength: 60),
                        Email = c.String(maxLength: 40),
                        PhoneNumber = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkPlace",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 150),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        UserId = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkPlace", "UserId", "dbo.User");
            DropIndex("dbo.WorkPlace", new[] { "UserId" });
            DropTable("dbo.WorkPlace");
            DropTable("dbo.User");
        }
    }
}
