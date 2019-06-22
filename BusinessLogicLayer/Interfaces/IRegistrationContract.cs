using System.ServiceModel;
using BusinessLogicLayer.DTO;

namespace BusinessLogicLayer.Interfaces
{
	[ServiceContract]
	public interface IRegistrationContract
	{
		[OperationContract]
		bool Register(UserDTO user);
	}
}