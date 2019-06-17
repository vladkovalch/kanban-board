using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace DataAccessLayer.Interfaces
{
	public interface IGenericRepository<TEntity> where TEntity : class
	{
		void Create(TEntity item);
		TEntity GetItem(TEntity item);
		TEntity GetItem(Func<TEntity, bool> predicate);
		TEntity GetItemById(int id);
		IEnumerable<TEntity> GetItems();
		IEnumerable<TEntity> GetItems(Func<TEntity, bool> predicate);
		void Remove(TEntity item);
		void Update(TEntity item);
	}

	public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
	{
		public DbContext Context { get; set; }
		public DbSet<TEntity> DbSet { get; set; }

		public GenericRepository(DbContext context)
		{
			Context = context;
			DbSet = context.Set<TEntity>();
		}

		virtual public IEnumerable<TEntity> GetItems()
		{
			return DbSet.AsNoTracking().ToList();
		}

		virtual public IEnumerable<TEntity> GetItems(Func<TEntity, bool> predicate)
		{
			return DbSet.AsNoTracking().Where(predicate).ToList();
		}

		virtual public TEntity GetItemById(int id)
		{
			return DbSet.Find(id);
		}

		public TEntity GetItem(TEntity item)
		{
			return DbSet.Find(item);
		}

		public TEntity GetItem(Func<TEntity, bool> predicate)
		{
			return DbSet.AsNoTracking().Where(predicate).FirstOrDefault();
		}

		virtual public void Create(TEntity item)
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