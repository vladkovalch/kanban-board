using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System.Data.Entity;

namespace BusinessLogicLayer.Repositories
{
	public class UserRepository : GenericRepository<User>
	{
		public UserRepository(DbContext context) : base(context)
		{ }
	}
}