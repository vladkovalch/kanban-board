using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer.Contracts
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuthorizationContract" in both code and config file together.
	[ServiceContract]
	public interface IAuthorizationContract
	{
		[OperationContract]
		void DoWork();
	}
}
