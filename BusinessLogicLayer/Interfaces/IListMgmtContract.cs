using System;
using System.Collections.Generic;
using System.ServiceModel;
using BusinessLogicLayer.DTO;

namespace BusinessLogicLayer.Interfaces.Contracts
{
	[ServiceContract]
	public interface IListMgmtContract
	{
		[OperationContract]
		void AddList(ListDTO list);

		[OperationContract]
		ListDTO FindListById(int id);

		[OperationContract]
		IEnumerable<ListDTO> GetLists();

		[OperationContract]
		IEnumerable<ListDTO> GetLists(Func<ListDTO, bool> predicate);

		[OperationContract]
		void RemoveList(ListDTO list);

		[OperationContract]
		void UpdateList(ListDTO list);
	}
}