namespace DataAccessLayer.Migrations
{
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.Context>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(DataAccessLayer.Context context)
		{ }
	}
}
