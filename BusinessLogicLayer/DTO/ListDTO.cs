using System.Collections.Generic;

namespace BusinessLogicLayer.DTO
{
	public class ListDTO
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public ICollection<CardDTO> Cards { get; set; }
	}
}
