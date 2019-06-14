using BusinessLogicLayer.DTO;
using BusinessLogicLayer.Interfaces.Contracts;
using System;
using System.Collections.Generic;

namespace BusinessLogicLayer.Services
{
	public class BoardsService : IBoardContract
	{
		public void AddBoard(BoardDTO board)
		{
			throw new NotImplementedException();
		}

		public BoardDTO FindBoardById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<BoardDTO> GetBoards()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<BoardDTO> GetBoards(Func<BoardDTO, bool> predicate)
		{
			throw new NotImplementedException();
		}

		public void RemoveBoard(BoardDTO board)
		{
			throw new NotImplementedException();
		}

		public void UpdateBoard(BoardDTO board)
		{
			throw new NotImplementedException();
		}
	}
}