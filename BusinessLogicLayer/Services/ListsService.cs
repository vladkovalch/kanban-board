using BusinessLogicLayer.DTO;
using BusinessLogicLayer.Interfaces.Contracts;
using System;
using System.Collections.Generic;

namespace BusinessLogicLayer.Services
{
	public class ListsService : IListContract
	{
		public void AddList(ListDTO list)
		{
			throw new NotImplementedException();
		}

		public ListDTO FindListById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ListDTO> GetLists()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ListDTO> GetLists(Func<ListDTO, bool> predicate)
		{
			throw new NotImplementedException();
		}

		public void RemoveList(ListDTO list)
		{
			throw new NotImplementedException();
		}

		public void UpdateList(ListDTO list)
		{
			throw new NotImplementedException();
		}
	}
}