namespace DataAccessLayer
{
	using System.Data.Entity;
	using DataAccessLayer.Models;

	public class Context : DbContext
	{
		public Context()
			: base("name=ConnectionString")
		{
            Database.SetInitializer<DropCreateDatabaseAlways>(new DropCreateDatabaseAlways());
        }

		public virtual DbSet<Board> Boards { get; set; }
		public virtual DbSet<Card> Cards { get; set; }
		public virtual DbSet<List> Lists { get; set; }

		public virtual DbSet<UserProfile> UserProfiles { get; set; }
		public virtual DbSet<User> Users { get; set; }
	}
}