using DataAccessLayer.Models;
using DataAccessLayer.Interfaces;
using System.Data.Entity;

namespace BusinessLogicLayer.Repositories
{
	public class UserProfileRepository : GenericRepository<UserProfile>
	{
		public UserProfileRepository(DbContext context) : base(context)
		{ }
	}
}
