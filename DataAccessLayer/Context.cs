namespace DataAccessLayer
{
	using DataAccessLayer.Models;
	using System.Data.Entity;

	public class Context : DbContext
	{
		public Context()
			: base("name=ConnectionString")
		{ }

		public virtual DbSet<Board> Boards { get; set; }
		public virtual DbSet<Card> Cards { get; set; }
		public virtual DbSet<List> Lists { get; set; }

		public virtual DbSet<UserProfile> UserProfiles { get; set; }
		public virtual DbSet<User> Users { get; set; }
	}
}