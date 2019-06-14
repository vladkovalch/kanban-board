using BusinessLogicLayer.DTO;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BusinessLogicLayer.Interfaces.Contracts
{
	[ServiceContract]
	public interface IUserContract
	{
		[OperationContract]
		void AddUser(UserDTO list);

		[OperationContract]
		UserDTO FindUserById(int id);

		[OperationContract]
		IEnumerable<UserDTO> GetUsers();

		[OperationContract]
		IEnumerable<UserDTO> GetUsers(Func<UserDTO, bool> predicate);

		[OperationContract]
		void RemoveUser(UserDTO list);

		[OperationContract]
		void UpdateUser(UserDTO list);
	}
}