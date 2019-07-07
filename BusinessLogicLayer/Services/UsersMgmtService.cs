using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.Interfaces.Contracts;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BusinessLogicLayer.Services
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
	public class UsersMgmtService : IUserMgmtContract
	{
		private readonly IGenericRepository<User> _repository;
		private readonly IMapper _mapper;

		public UsersMgmtService(IGenericRepository<User> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public void AddUser(UserDTO user)
		{
			try
			{
				_repository.Create(_mapper.Map<User>(user));
			}
			catch (Exception)
			{ }
		}

		public UserDTO FindUserById(int id)
		{
			try
			{
				return _mapper.Map<UserDTO>(_repository.GetItemById(id));
			}
			catch (Exception)
			{
				return null;
			}
		}

		public IEnumerable<UserDTO> GetUsers()
		{
			try
			{
				List<UserDTO> users = new List<UserDTO>();
				foreach (User user in _repository.GetItems())
				{
					users.Add(_mapper.Map<UserDTO>(user));
				}

				return users;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public IEnumerable<UserDTO> GetUsers(Func<UserDTO, bool> predicate)
		{
			try
			{
				List<UserDTO> users = new List<UserDTO>();
				foreach (User user in _repository.GetItems(_mapper.Map<Func<User, bool>>(predicate)))
				{
					users.Add(_mapper.Map<UserDTO>(user));
				}

				return users;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public void RemoveUser(UserDTO user)
		{
			try
			{
				_repository.Remove(_mapper.Map<User>(user));
			}
			catch (Exception)
			{ }
		}

		public void UpdateUser(UserDTO user)
		{
			try
			{
				_repository.Update(_mapper.Map<User>(user));
			}
			catch (Exception)
			{ }
		}
	}
}