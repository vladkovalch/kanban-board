using BusinessLogicLayer.DTO;
using BusinessLogicLayer.Interfaces.Contracts;
using System;
using System.Collections.Generic;

namespace BusinessLogicLayer.Services
{
	public class CardsService : ICardContract
	{
		public void AddCard(CardDTO card)
		{
			throw new NotImplementedException();
		}

		public CardDTO FindCardById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<CardDTO> GetCards()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<CardDTO> GetCards(Func<CardDTO, bool> predicate)
		{
			throw new NotImplementedException();
		}

		public void RemoveCard(CardDTO card)
		{
			throw new NotImplementedException();
		}

		public void UpdateCard(CardDTO card)
		{
			throw new NotImplementedException();
		}
	}
}