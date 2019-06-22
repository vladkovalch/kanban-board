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
	public class BoardsMgmtService : IBoardMgmtContract
	{
		private readonly IGenericRepository<Board> _repository;
		private readonly IMapper _mapper;

		public BoardsMgmtService(IGenericRepository<Board> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public void AddBoard(BoardDTO board)
		{
			try
			{
				_repository.Create(_mapper.Map<Board>(board));
			}
			catch (Exception)
			{ }
		}

		public BoardDTO FindBoardById(int id)
		{
			try
			{
				return _mapper.Map<BoardDTO>(_repository.GetItemById(id));
			}
			catch (Exception)
			{
				return null;
			}
		}

		public IEnumerable<BoardDTO> GetBoards()
		{
			try
			{
				List<BoardDTO> boards = new List<BoardDTO>();
				foreach (Board board in _repository.GetItems())
				{
					boards.Add(_mapper.Map<BoardDTO>(board));
				}

				return boards;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public IEnumerable<BoardDTO> GetBoards(Func<BoardDTO, bool> predicate)
		{
			try
			{
				List<BoardDTO> boards = new List<BoardDTO>();
				foreach (Board board in _repository.GetItems(_mapper.Map<Func<Board, bool>>(predicate)))
				{
					boards.Add(_mapper.Map<BoardDTO>(board));
				}

				return boards;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public void RemoveBoard(BoardDTO board)
		{
			try
			{
				_repository.Remove(_mapper.Map<Board>(board));
			}
			catch (Exception)
			{ }
		}

		public void UpdateBoard(BoardDTO board)
		{
			try
			{
				_repository.Update(_mapper.Map<Board>(board));
			}
			catch (Exception)
			{ }
		}
	}
}