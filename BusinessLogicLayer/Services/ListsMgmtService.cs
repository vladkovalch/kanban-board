using System;
using System.Collections.Generic;
using System.ServiceModel;
using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.Interfaces.Contracts;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Services
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
	public class ListsMgmtService : IListMgmtContract
	{
		private readonly IGenericRepository<List> _repository;
		private readonly IMapper _mapper;

		public ListsMgmtService(IGenericRepository<List> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public void AddList(ListDTO list)
		{
			try
			{
				_repository.Create(_mapper.Map<List>(list));
			}
			catch (Exception)
			{ }
		}

		public ListDTO FindListById(int id)
		{
			try
			{
				return _mapper.Map<ListDTO>(_repository.GetItemById(id));
			}
			catch (Exception)
			{
				return null;
			}
		}

		public IEnumerable<ListDTO> GetLists()
		{
			try
			{
				List<ListDTO> lists = new List<ListDTO>();
				foreach (List list in _repository.GetItems())
				{
					lists.Add(_mapper.Map<ListDTO>(list));
				}

				return lists;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public IEnumerable<ListDTO> GetLists(Func<ListDTO, bool> predicate)
		{
			try
			{
				List<ListDTO> lists = new List<ListDTO>();
				foreach (List list in _repository.GetItems(_mapper.Map<Func<List, bool>>(predicate)))
				{
					lists.Add(_mapper.Map<ListDTO>(list));
				}

				return lists;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public void RemoveList(ListDTO list)
		{
			try
			{
				_repository.Remove(_mapper.Map<List>(list));
			}
			catch (Exception)
			{ }
		}

		public void UpdateList(ListDTO list)
		{
			try
			{
				_repository.Update(_mapper.Map<List>(list));
			}
			catch (Exception)
			{ }
		}
	}
}