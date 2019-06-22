using System.ServiceModel;
using BusinessLogicLayer.DTO;

namespace BusinessLogicLayer.Interfaces.Contracts
{
	[ServiceContract]
	public interface IAuthorizationContract
	{
		[OperationContract]
		bool Login(UserDTO user);

		[OperationContract]
		bool CheckEmailIsExist(string email);

		[OperationContract]
		bool CheckIsPasswordMatch(string email, string password);
	}
}