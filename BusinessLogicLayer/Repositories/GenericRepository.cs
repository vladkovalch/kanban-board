using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer.Repositories
{
	public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
	{
		public DbContext Context { get; set; }
		public DbSet<TEntity> DbSet { get; set; }

		public GenericRepository(DbContext context)
		{
			Context = context;
			DbSet = context.Set<TEntity>();
		}

		virtual public IEnumerable<TEntity> Get()
		{
			return DbSet.AsNoTracking().ToList();
		}

		virtual  public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
		{
			return DbSet.AsNoTracking().Where(predicate).ToList();
		}
		virtual  public TEntity FindById(int id)
		{
			return DbSet.Find(id);
		}

		virtual  public void Create(TEntity item)
		{
			DbSet.Add(item);
			Context.SaveChanges();
		}

		virtual public void Update(TEntity item)
		{
			Context.Entry(item).State = EntityState.Modified;
			Context.SaveChanges();
		}
		virtual public void Remove(TEntity item)
		{
			DbSet.Remove(item);
			Context.SaveChanges();
		}
	}
}
