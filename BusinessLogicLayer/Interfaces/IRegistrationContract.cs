using BusinessLogicLayer.DTO;
using System.ServiceModel;

namespace BusinessLogicLayer.Interfaces
{
	[ServiceContract]
	public interface IRegistrationContract
	{
		[OperationContract]
		bool Register(UserDTO user);
	}
}