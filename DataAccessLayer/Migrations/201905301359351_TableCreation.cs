namespace DataAccessLayer.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class TableCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 24),
                        Description = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Lists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 24),
                        Board_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Boards", t => t.Board_Id)
                .Index(t => t.Board_Id);
            
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 12),
                        CreationTime = c.DateTime(nullable: false),
                        List_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lists", t => t.List_Id)
                .Index(t => t.List_Id);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 24),
                        SecondName = c.String(nullable: false, maxLength: 42),
                        ImagePath = c.String(nullable: false, maxLength: 255),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 64),
                        Sha256Password = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfiles", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Id", "dbo.UserProfiles");
            DropForeignKey("dbo.Lists", "Board_Id", "dbo.Boards");
            DropForeignKey("dbo.Cards", "List_Id", "dbo.Lists");
            DropIndex("dbo.Users", new[] { "Id" });
            DropIndex("dbo.Cards", new[] { "List_Id" });
            DropIndex("dbo.Lists", new[] { "Board_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Cards");
            DropTable("dbo.Lists");
            DropTable("dbo.Boards");
        }
    }
}
