using BusinessLogicLayer.DTO;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BusinessLogicLayer.Interfaces.Contracts
{
	[ServiceContract]
	public interface IBoardMgmtContract
	{
		[OperationContract]
		void AddBoard(BoardDTO board);

		[OperationContract]
		BoardDTO FindBoardById(int id);

		[OperationContract]
		IEnumerable<BoardDTO> GetBoards();

		[OperationContract]
		IEnumerable<BoardDTO> GetBoards(Func<BoardDTO, bool> predicate);

		[OperationContract]
		void RemoveBoard(BoardDTO board);

		[OperationContract]
		void UpdateBoard(BoardDTO board);
	}
}