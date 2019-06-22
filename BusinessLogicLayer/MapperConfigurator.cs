using System;
using AutoMapper;
using BusinessLogicLayer.DTO;
using DataAccessLayer.Models;

namespace BusinessLogicLayer
{
	public class MapperConfigurator : Profile
	{
		public MapperConfigurator()
		{
			CreateMap<User, UserDTO>();
			CreateMap<UserDTO, User>();

			CreateMap<UserProfile, UserProfileDTO>();
			CreateMap<UserProfileDTO, UserProfile>();

			CreateMap<Board, BoardDTO>();
			CreateMap<BoardDTO, Board>();

			CreateMap<List, ListDTO>();
			CreateMap<ListDTO, List>();

			CreateMap<Card, CardDTO>();
			CreateMap<CardDTO, Card>();

			CreateMap<Func<User, bool>, Func<UserDTO, bool>>();
			CreateMap<Func<UserDTO, bool>, Func<User, bool>>();

			CreateMap<Func<UserProfile, bool>, Func<UserProfileDTO, bool>>();
			CreateMap<Func<UserProfileDTO, bool>, Func<UserProfile, bool>>();

			CreateMap<Func<Board, bool>, Func<BoardDTO, bool>>();
			CreateMap<Func<BoardDTO, bool>, Func<Board, bool>>();

			CreateMap<Func<List, bool>, Func<ListDTO, bool>>();
			CreateMap<Func<ListDTO, bool>, Func<List, bool>>();

			CreateMap<Func<Card, bool>, Func<CardDTO, bool>>();
			CreateMap<Func<CardDTO, bool>, Func<Card, bool>>();
		}

		//public IMapper ConfigureServices()
		//{
		//	var config = new MapperConfiguration(cfg =>
		//	{
		//		cfg.CreateMap<User, UserDTO>();
		//		cfg.CreateMap<UserDTO, User>();

		//		cfg.CreateMap<UserProfile, UserProfileDTO>();
		//		cfg.CreateMap<UserProfileDTO, UserProfile>();

		//		cfg.CreateMap<Board, BoardDTO>();
		//		cfg.CreateMap<BoardDTO, Board>();

		//		cfg.CreateMap<List, ListDTO>();
		//		cfg.CreateMap<ListDTO, List>();

		//		cfg.CreateMap<Card, CardDTO>();
		//		cfg.CreateMap<CardDTO, Card>();

		//		cfg.CreateMap<Func<User, bool>, Func<UserDTO, bool>>();
		//		cfg.CreateMap<Func<UserDTO, bool>, Func<User, bool>>();

		//		cfg.CreateMap<Func<UserProfile, bool>, Func<UserProfileDTO, bool>>();
		//		cfg.CreateMap<Func<UserProfileDTO, bool>, Func<UserProfile, bool>>();

		//		cfg.CreateMap<Func<Board, bool>, Func<BoardDTO, bool>>();
		//		cfg.CreateMap<Func<BoardDTO, bool>, Func<Board, bool>>();

		//		cfg.CreateMap<Func<List, bool>, Func<ListDTO, bool>>();
		//		cfg.CreateMap<Func<ListDTO, bool>, Func<List, bool>>();

		//		cfg.CreateMap<Func<Card, bool>, Func<CardDTO, bool>>();
		//		cfg.CreateMap<Func<CardDTO, bool>, Func<Card, bool>>();
		//	});

		//	IMapper mapper = config.CreateMapper();
		//	return mapper;
		//}
	}
}