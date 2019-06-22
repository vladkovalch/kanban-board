using System.Data.Entity;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Repositories
{
	public class UserRepository : GenericRepository<User>
	{
		public UserRepository(DbContext context) : base(context)
		{ }
	}
}