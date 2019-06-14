using BusinessLogicLayer.DTO;
using System.ServiceModel;

namespace BusinessLogicLayer.Interfaces.Contracts
{
	[ServiceContract]
	public interface IAuthorizationContract
	{
		[OperationContract]
		bool Register(UserDTO user);

		[OperationContract]
		bool Login(UserDTO user);
	}
}