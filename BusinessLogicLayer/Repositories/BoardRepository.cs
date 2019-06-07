using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using System.Data.Entity;

namespace BusinessLogicLayer.Repositories
{
	public class BoardRepository : GenericRepository<Board>
	{
		public BoardRepository(DbContext context) : base(context)
		{ }
	}
}
