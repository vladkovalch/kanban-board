using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;

namespace BusinessLogicLayer.Services
{
	public class RegistrationService : IRegistrationContract
	{
		private readonly IGenericRepository<User> _repository;
		private readonly IMapper _mapper;

		public RegistrationService(IGenericRepository<User> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public bool Register(UserDTO user)
		{
			try
			{
				if (_repository.GetItem(x => x.Email == user.Email) == null)
				{
					_repository.Create(_mapper.Map<User>(user));
					return true;
				}

				return false;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}