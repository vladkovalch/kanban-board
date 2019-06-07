using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using System.Data.Entity;

namespace BusinessLogicLayer.Repositories
{
	public class ListRepository : GenericRepository<List>
	{
		public ListRepository(DbContext context) : base(context)
		{ }
	}
}
