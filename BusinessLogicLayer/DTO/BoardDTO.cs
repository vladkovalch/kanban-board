using System.Collections.Generic;

namespace BusinessLogicLayer.DTO
{
	public class BoardDTO
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public ICollection<ListDTO> Lists { get; set; }
		public ICollection<UserDTO> Users { get; set; }
	}
}