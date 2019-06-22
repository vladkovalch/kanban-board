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
	public class CardsMgmtService : ICardMgmtContract
	{
		private readonly IGenericRepository<Card> _repository;
		private readonly IMapper _mapper;

		public CardsMgmtService(IGenericRepository<Card> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public void AddCard(CardDTO card)
		{
			try
			{
				_repository.Create(_mapper.Map<Card>(card));
			}
			catch (Exception)
			{ }
		}

		public CardDTO FindCardById(int id)
		{
			try
			{
				return _mapper.Map<CardDTO>(_repository.GetItemById(id));
			}
			catch (Exception)
			{
				return null;
			}
		}

		public IEnumerable<CardDTO> GetCards()
		{
			try
			{
				List<CardDTO> cards = new List<CardDTO>();
				foreach (Card card in _repository.GetItems())
				{
					cards.Add(_mapper.Map<CardDTO>(card));
				}

				return cards;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public IEnumerable<CardDTO> GetCards(Func<CardDTO, bool> predicate)
		{
			try
			{
				List<CardDTO> cards = new List<CardDTO>();
				foreach (Card card in _repository.GetItems(_mapper.Map<Func<Card, bool>>(predicate)))
				{
					cards.Add(_mapper.Map<CardDTO>(card));
				}

				return cards;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public void RemoveCard(CardDTO card)
		{
			try
			{
				_repository.Remove(_mapper.Map<Card>(card));
			}
			catch (Exception)
			{ }
		}

		public void UpdateCard(CardDTO card)
		{
			try
			{
				_repository.Update(_mapper.Map<Card>(card));
			}
			catch (Exception)
			{ }
		}
	}
}