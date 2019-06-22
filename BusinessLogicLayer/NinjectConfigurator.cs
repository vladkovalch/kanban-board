using System.Data.Entity;
using Ninject.Modules;
using BusinessLogicLayer.Repositories;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using AutoMapper;

namespace BusinessLogicLayer
{
	public class NinjectConfigurator : NinjectModule
	{
		public override void Load()
		{
			Bind<DbContext>().To<Context>();
			Bind<IGenericRepository<UserProfile>>().To<UserProfileRepository>();
			Bind<IGenericRepository<User>>().To<UserRepository>();
			Bind<IGenericRepository<Board>>().To<BoardRepository>();
			Bind<IGenericRepository<List>>().To<ListRepository>();
			Bind<IGenericRepository<Card>>().To<CardRepository>();
		}
	}
}