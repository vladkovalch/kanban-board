using System.Data.Entity;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Repositories
{
	public class CardRepository : GenericRepository<Card>
	{
		public CardRepository(DbContext context) : base(context)
		{ }
	}
}