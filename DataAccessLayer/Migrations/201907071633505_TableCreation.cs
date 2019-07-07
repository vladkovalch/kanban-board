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
				"dbo.Users",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					Email = c.String(nullable: false, maxLength: 64),
					Sha256Password = c.String(nullable: false, maxLength: 256),
					ProfileId = c.Int(nullable: false),
				})
				.PrimaryKey(t => t.Id);

			CreateTable(
				"dbo.UserProfiles",
				c => new
				{
					Id = c.Int(nullable: false),
					FirstName = c.String(nullable: false, maxLength: 24),
					SecondName = c.String(nullable: false, maxLength: 42),
					ImagePath = c.String(nullable: false, maxLength: 255),
				})
				.PrimaryKey(t => t.Id)
				.ForeignKey("dbo.Users", t => t.Id)
				.Index(t => t.Id);

			CreateTable(
				"dbo.UserBoards",
				c => new
				{
					User_Id = c.Int(nullable: false),
					Board_Id = c.Int(nullable: false),
				})
				.PrimaryKey(t => new { t.User_Id, t.Board_Id })
				.ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
				.ForeignKey("dbo.Boards", t => t.Board_Id, cascadeDelete: true)
				.Index(t => t.User_Id)
				.Index(t => t.Board_Id);
		}

		public override void Down()
		{
			DropForeignKey("dbo.UserProfiles", "Id", "dbo.Users");
			DropForeignKey("dbo.UserBoards", "Board_Id", "dbo.Boards");
			DropForeignKey("dbo.UserBoards", "User_Id", "dbo.Users");
			DropForeignKey("dbo.Lists", "Board_Id", "dbo.Boards");
			DropForeignKey("dbo.Cards", "List_Id", "dbo.Lists");
			DropIndex("dbo.UserBoards", new[] { "Board_Id" });
			DropIndex("dbo.UserBoards", new[] { "User_Id" });
			DropIndex("dbo.UserProfiles", new[] { "Id" });
			DropIndex("dbo.Cards", new[] { "List_Id" });
			DropIndex("dbo.Lists", new[] { "Board_Id" });
			DropTable("dbo.UserBoards");
			DropTable("dbo.UserProfiles");
			DropTable("dbo.Users");
			DropTable("dbo.Cards");
			DropTable("dbo.Lists");
			DropTable("dbo.Boards");
		}
	}
}