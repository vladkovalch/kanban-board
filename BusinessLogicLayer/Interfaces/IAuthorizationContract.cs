using BusinessLogicLayer.DTO;
using System.ServiceModel;

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