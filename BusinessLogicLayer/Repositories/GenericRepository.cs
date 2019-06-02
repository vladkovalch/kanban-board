using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
	{
		public DbContext Context { get; set; }
		public DbSet<TEntity> DbSet { get; set; }

		public GenericRepository(DbContext context)
		{
			Context = context;
			DbSet = context.Set<TEntity>();
		}

		public IEnumerable<TEntity> Get()
		{
			return DbSet.AsNoTracking().ToList();
		}

		public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
		{
			return DbSet.AsNoTracking().Where(predicate).ToList();
		}
		public TEntity FindById(int id)
		{
			return DbSet.Find(id);
		}

		public void Create(TEntity item)
		{
			DbSet.Add(item);
			Context.SaveChanges();
		}
		public void Update(TEntity item)
		{
			Context.Entry(item).State = EntityState.Modified;
			Context.SaveChanges();
		}
		public void Remove(TEntity item)
		{
			DbSet.Remove(item);
			Context.SaveChanges();
		}
	}
}
