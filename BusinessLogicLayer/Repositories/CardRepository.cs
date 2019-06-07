using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System.Data.Entity;

namespace BusinessLogicLayer.Repositories
{
	public class CardRepository : GenericRepository<Card>
	{
		public CardRepository(DbContext context) : base(context)
		{ }
	}
}
