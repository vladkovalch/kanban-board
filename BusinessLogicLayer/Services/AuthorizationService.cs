using System;
using System.ServiceModel;
using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.Interfaces.Contracts;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Services
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
	public class AuthorizationService : IAuthorizationContract
	{
		private readonly IGenericRepository<User> _repository;
		private readonly IMapper _mapper;

		public AuthorizationService(IGenericRepository<User> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public bool Login(UserDTO user)
		{
			try
			{
				return _repository.GetItem(_mapper.Map<User>(user)) == null;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool CheckEmailIsExist(string email)
		{
			try
			{
				return _repository.GetItem(x => x.Email == email) != null;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool CheckIsPasswordMatch(string email, string password)
		{
			try
			{
				User user = _repository.GetItem(x => x.Email == email);
				return user != null && user.Sha256Password == password;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}