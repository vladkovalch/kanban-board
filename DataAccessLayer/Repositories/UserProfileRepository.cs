using System.Data.Entity;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Repositories
{
	public class UserProfileRepository : GenericRepository<UserProfile>
	{
		public UserProfileRepository(DbContext context) : base(context)
		{ }
	}
}