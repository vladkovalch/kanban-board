using System.Data.Entity;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Repositories
{
	public class BoardRepository : GenericRepository<Board>
	{
		public BoardRepository(DbContext context) : base(context)
		{ }
	}
}