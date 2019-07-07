using System.IO;
using AutoMapper;
using Ninject;
using BusinessLogicLayer;
using BusinessLogicLayer.Services;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System.ServiceModel;
using System;

namespace WcfConsoleHost
{
	public static class NinjectFactory
	{
		public static StandardKernel Kernel;

		static NinjectFactory()
		{
			Kernel = new StandardKernel(new NinjectConfigurator());
		}
	}

	public class Configurator
	{
		private static IGenericRepository<User> _userRepository { get; set; }
		private static IGenericRepository<UserProfile> _userProfileRepository { get; set; }
		private static IGenericRepository<Board> _boardRepository { get; set; }
		private static IGenericRepository<List> _listRepository { get; set; }
		private static IGenericRepository<Card> _cardRepository { get; set; }

		private static TextWriter _textWriter { get; set; }
		private static MapperConfiguration _mapperConfiguration { get; set; }
		private static IMapper _mapper { get; set; }

		public Configurator()
		{
			_userRepository = NinjectFactory.Kernel.Get<IGenericRepository<User>>();
			_userProfileRepository = NinjectFactory.Kernel.Get<IGenericRepository<UserProfile>>();
			_boardRepository = NinjectFactory.Kernel.Get<IGenericRepository<Board>>();
			_listRepository = NinjectFactory.Kernel.Get<IGenericRepository<List>>();
			_cardRepository = NinjectFactory.Kernel.Get<IGenericRepository<Card>>();

			_mapperConfiguration = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new MapperConfigurator());
			});

			_mapper = _mapperConfiguration.CreateMapper();
		}

		public void Configure(TextWriter _textWriter)
		{
			try
			{
				AuthorizationService authorizationService = new AuthorizationService(_userRepository, _mapper);
				ServiceHost authorizationServiceHost = new ServiceHost(authorizationService);
				authorizationServiceHost.Open();
				_textWriter.WriteLine("Authorization service was started!");

				UsersMgmtService usersMgmtService = new UsersMgmtService(_userRepository, _mapper);
				ServiceHost usersMgmtServiceHost = new ServiceHost(usersMgmtService);
				usersMgmtServiceHost.Open();
				_textWriter.WriteLine("Users management service was started!");

				BoardsMgmtService boardsMgmtService = new BoardsMgmtService(_boardRepository, _mapper);
				ServiceHost boardsMgmtServiceHost = new ServiceHost(boardsMgmtService);
				boardsMgmtServiceHost.Open();
				_textWriter.WriteLine("Boards management service was started!");

				ListsMgmtService listsMgmtService = new ListsMgmtService(_listRepository, _mapper);
				ServiceHost listsMgmtServiceHost = new ServiceHost(listsMgmtService);
				listsMgmtServiceHost.Open();
				_textWriter.WriteLine("Lists management service was started!");

				CardsMgmtService cardsMgmtService = new CardsMgmtService(_cardRepository, _mapper);
				ServiceHost cardsMgmtServiceHost = new ServiceHost(cardsMgmtService);
				cardsMgmtServiceHost.Open();
				_textWriter.WriteLine("Cards management service was started!");

				RegistrationService registration = new RegistrationService(_userRepository, _mapper);
				ServiceHost regServiceHost = new ServiceHost(registration);
				regServiceHost.Open();
				_textWriter.WriteLine("Registration management service was started!");
			}
			catch (Exception ex)
			{
				_textWriter.Write(ex.Message);
			}
		}
	}
}