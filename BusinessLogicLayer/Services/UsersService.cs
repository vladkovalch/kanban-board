using BusinessLogicLayer.DTO;
using BusinessLogicLayer.Interfaces.Contracts;
using System;
using System.Collections.Generic;

namespace BusinessLogicLayer.Services
{
	public class UsersService : IUserContract
	{
		public void AddUser(UserDTO list)
		{
			throw new NotImplementedException();
		}

		public UserDTO FindUserById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<UserDTO> GetUsers()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<UserDTO> GetUsers(Func<UserDTO, bool> predicate)
		{
			throw new NotImplementedException();
		}

		public void RemoveUser(UserDTO list)
		{
			throw new NotImplementedException();
		}

		public void UpdateUser(UserDTO list)
		{
			throw new NotImplementedException();
		}
	}
}