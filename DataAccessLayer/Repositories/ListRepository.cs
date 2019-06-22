using System.Data.Entity;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Repositories
{
	public class ListRepository : GenericRepository<List>
	{
		public ListRepository(DbContext context) : base(context)
		{ }
	}
}