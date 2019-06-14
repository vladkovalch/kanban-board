using System.Collections.Generic;

namespace BusinessLogicLayer.DTO
{
	public class UserDTO
	{
		public int Id { get; set; }

		public string Email { get; set; }

		public string Sha256Password { get; set; }

		public int ProfileId { get; set; }

		public ICollection<BoardDTO> Boards { get; set; }
	}
}