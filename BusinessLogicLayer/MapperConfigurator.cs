using AutoMapper;
using BusinessLogicLayer.DTO;
using DataAccessLayer.Models;
using System;

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
	}
}