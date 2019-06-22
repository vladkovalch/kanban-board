using System;
using System.Collections.Generic;
using System.ServiceModel;
using BusinessLogicLayer.DTO;

namespace BusinessLogicLayer.Interfaces.Contracts
{
	[ServiceContract]
	public interface IUserMgmtContract
	{
		[OperationContract]
		void AddUser(UserDTO user);

		[OperationContract]
		UserDTO FindUserById(int id);

		[OperationContract]
		IEnumerable<UserDTO> GetUsers();

		[OperationContract]
		IEnumerable<UserDTO> GetUsers(Func<UserDTO, bool> predicate);

		[OperationContract]
		void RemoveUser(UserDTO user);

		[OperationContract]
		void UpdateUser(UserDTO user);
	}
}